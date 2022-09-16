using Management.Data;
using Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword()
        {
            var roles = from r in _context.Roles
                        where r.Name == "Admin"
                        select r;
            var users = from u in _context.Users
                        where u.Role == roles.SingleOrDefault()
                        select u;
            IndexModel model = new()
            {
                Users = await users.ToListAsync()
            };
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var allUsers = from aU in _context.Users
                           where aU.Email == this.User.Identity.Name
                           select aU;
            var issues = from i in _context.Issues
                         select i;
            var users = from u in _context.Users
                        select u;
            var statuses = from s in _context.Statuses
                           select s;
            var roles = from r in _context.Roles
                        select r;
            var userRoles = from uR in _context.UserRoles
                            select uR;
            foreach (var i in issues)
            {
                i.Status = statuses.Where(s => s.Id == i.StatusId).SingleOrDefault();
                i.Parent = issues.Where(issue => issue.Id == i.ParentId).SingleOrDefault();
            }


            IndexModel model = new()
            {
                Issues = await issues.Where(i => i.isProject == false).ToListAsync(),
                Projects = await issues.Where(p => p.isProject == true).ToListAsync(),
                Users = await users.ToListAsync(),
                OpenIssues = await issues.Where(i => i.Status.Id == 1).ToListAsync(),
                InProgressIssues = await issues.Where(i => i.Status.Id == 2).ToListAsync(),
                DoneIssues = await issues.Where(i => i.Status.Id == 3).ToListAsync(),
                LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName,
                LoggedUserLastName = allUsers.SingleOrDefault()?.LastName,
                LoggedUserId = allUsers.SingleOrDefault()?.Id,
                LoggedUser = allUsers.SingleOrDefault(),
                Statuses = await statuses.ToListAsync(),
                Roles = await roles.ToListAsync()
            };


            var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
            var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
            model.LoggedUser.Role = loggedUser_Role;



            List<Issue> OwnProjects = new List<Issue>();
            List<Issue> OwnProjectsIssuesOPEN = new List<Issue>();
            List<Issue> OwnProjectsIssuesINPROGRESS = new List<Issue>();
            List<Issue> OwnProjectsIssuesDONE = new List<Issue>();

            model.OpenIssues = await issues.Where(i => i.Status.Id == 1 && i.Assignee.Id == model.LoggedUser.Id).ToListAsync();
            model.InProgressIssues = await issues.Where(i => i.Status.Id == 2 && i.Assignee.Id == model.LoggedUser.Id).ToListAsync();
            model.DoneIssues = await issues.Where(i => i.Status.Id == 3 && i.Assignee.Id == model.LoggedUser.Id).ToListAsync();
            if (model.LoggedUser.Role.Name != "User")
            {

                OwnProjects = model.Projects.Where(p => p.Assignee.Id == model.LoggedUser.Id).ToList();
                foreach (var proj in OwnProjects)
                {
                    foreach (var i in model.Issues)
                    {
                        if (i.Parent.Id == proj.Id)
                        {
                            bool hasBeenAddedOPEN = false;
                            bool hasBeenAddedINPROGRESS= false;
                            bool hasBeenAddedDONE= false;
                            foreach (var opi in model.OpenIssues)
                            {
                                if (opi.Id == i.Id) { hasBeenAddedOPEN = true; break; }
                            }
                            if (!hasBeenAddedOPEN) { OwnProjectsIssuesOPEN.Add(i); }

                            foreach (var opi in model.InProgressIssues)
                            {
                                if (opi.Id == i.Id) { hasBeenAddedINPROGRESS = true; break; }
                            }
                            if (!hasBeenAddedINPROGRESS) { OwnProjectsIssuesINPROGRESS.Add(i); }

                            foreach (var opi in model.DoneIssues)
                            {
                                if (opi.Id == i.Id) { hasBeenAddedDONE = true; break; }
                            }
                            if (!hasBeenAddedDONE) { OwnProjectsIssuesDONE.Add(i); }
                        }
                    }
                }
                model.OpenIssues.AddRange(OwnProjectsIssuesOPEN.Where(i => i.Status.Id == 1));
                model.InProgressIssues.AddRange(OwnProjectsIssuesINPROGRESS.Where(i => i.Status.Id == 2));
                model.DoneIssues.AddRange(OwnProjectsIssuesDONE.Where(i => i.Status.Id == 3));
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}