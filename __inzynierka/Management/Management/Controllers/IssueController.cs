using Management.Data;
using Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using System.Web;

namespace Management.Controllers;

[Controller]
[Route("[controller]")]
public class IssueController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public IssueController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    // GET: Issue
    [Authorize]
    public async Task<IActionResult> Index()
    {
        var allUsers = from aU in _context.Users
                       where aU.Email == User.Identity.Name
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
        List<Issue> OwnProjectsIssues = new List<Issue>();
        List<Issue> AllIssues = model.Issues;

        model.Issues = await issues.Where(i => i.Assignee.Id == model.LoggedUser.Id && !i.isProject).ToListAsync();
        if (model.LoggedUser.Role.Name != "User")
        {

            OwnProjects = model.Projects.Where(p => p.Assignee.Id == model.LoggedUser.Id).ToList();
            foreach (var proj in OwnProjects)
            {
                foreach (var i in AllIssues)
                {
                    if (i.Parent.Id == proj.Id)
                    {
                        bool hasBeenAdded = false;
                        foreach (var opi in model.Issues)
                        {
                            if(opi.Id == i.Id) { hasBeenAdded = true; break; }
                        }
                        if (!hasBeenAdded) { OwnProjectsIssues.Add(i); }
                    }
                }
            }
            model.Issues.AddRange(OwnProjectsIssues);
        }



        return View(model);
    }



    // GET: Issue/Details/5
    [HttpGet("Details/{id:int}")]
    [Authorize]
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var allUsers = from aU in _context.Users
                       where aU.Email == User.Identity.Name
                       select aU;
        var users = from u in _context.Users
                    select u;
        var actualIssue = from aI in _context.Issues
                          where aI.Id == id
                          select aI;
        var issues = from i in _context.Issues
                     select i;
        var statuses = from s in _context.Statuses
                       select s;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        IndexModel model = new()
        {
            Users = await users.ToListAsync(),
            LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName,
            LoggedUserLastName = allUsers.SingleOrDefault()?.LastName,
            LoggedUserId = allUsers.SingleOrDefault()?.Id,
            LoggedUser = allUsers.SingleOrDefault(),
            Issues = await issues.Where(i => i.isProject == false).ToListAsync(),
            Statuses = await statuses.ToListAsync(),
            ActualIssue = actualIssue.SingleOrDefault()
        };


        var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
        var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
        model.LoggedUser.Role = loggedUser_Role;

        model.IssueDescriptionDto = actualIssue.SingleOrDefault()?.Description;
        if (model.isAfterEdit is null)
        {
            model.isAfterEdit = false;
        }
        foreach (var issue in model.Issues)
        {
            var assignee = model.Users.Where(u => u.Id == issue.AssigneeId).SingleOrDefault();
            var status = model.Statuses.Where(s => s.Id == issue.StatusId).SingleOrDefault();
            var parent = issues.Where(i => issue.ParentId == i.Id).SingleOrDefault();
        }
        if (actualIssue == null)
        {
            return NotFound();
        }

        return View(model);
    }



    // POST: Issue/Details/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost("Details/{id:int}")]
    [ValidateAntiForgeryToken]
    [Authorize]
    public async Task<IActionResult> Details(int id, [Bind("IssueNameDto", "IssueStatusNameDto", "IssueStartDateDto", "IssueEndDateDto", "IssueAssigneeNameDto", "IssueDescriptionDto")] IndexModel model)
    {
        var allUsers = from aU in _context.Users
                       where aU.Email == User.Identity.Name
                       select aU;
        var users = from u in _context.Users
                    select u;
        var actualIssue = from aI in _context.Issues
                          where aI.Id == id
                          select aI;
        var issues = from i in _context.Issues
                     select i;
        var statuses = from s in _context.Statuses
                       select s;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        model.Users = await users.ToListAsync();
        model.LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName;
        model.LoggedUserLastName = allUsers.SingleOrDefault()?.LastName;
        model.LoggedUserId = allUsers.SingleOrDefault()?.Id;
        model.LoggedUser = allUsers.SingleOrDefault();
        model.Issues = await issues.Where(i => i.isProject == false).ToListAsync();
        model.Statuses = await statuses.ToListAsync();
        model.ActualIssue = actualIssue.SingleOrDefault();

        var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
        var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
        model.LoggedUser.Role = loggedUser_Role;

        foreach (var issue in model.Issues)
        {
            var assignee = model.Users.Where(u => u.Id == issue.AssigneeId).SingleOrDefault();
            var status = model.Statuses.Where(s => s.Id == issue.StatusId).SingleOrDefault();
            var parent = issues.Where(i => issue.ParentId == i.Id).SingleOrDefault();
        }
        if (id != model.ActualIssue.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                if (model.IssueNameDto != null)
                {
                    model.ActualIssue.Name = model.IssueNameDto;
                }
                var newStatus = model.Statuses.Where(s => s.Name == model.IssueStatusNameDto).SingleOrDefault();
                model.ActualIssue.Status = newStatus;
                model.ActualIssue.StatusId = newStatus.Id;

                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();
                if (model.IssueStartDateDto is not null)
                {
                    int.TryParse(model.IssueStartDateDto.Substring(0, 4), out int year);
                    int.TryParse(model.IssueStartDateDto.Substring(5, 2), out int month);
                    int.TryParse(model.IssueStartDateDto.Substring(8, 2), out int day);
                    model.ActualIssue.Start = new DateTime(year, month, day);
                    startDate = new DateTime(year, month, day);
                }
                if (model.IssueEndDateDto is not null)
                {
                    int.TryParse(model.IssueEndDateDto.Substring(0, 4), out int year);
                    int.TryParse(model.IssueEndDateDto.Substring(5, 2), out int month);
                    int.TryParse(model.IssueEndDateDto.Substring(8, 2), out int day);
                    model.ActualIssue.End = new DateTime(year, month, day);
                    endDate = new DateTime(year, month, day);
                }

                int duration = 1;
                if (model.IssueStartDateDto is not null && model.IssueEndDateDto is not null)
                {
                    TimeSpan interval = endDate - startDate;
                    duration = interval.Days;
                    model.ActualIssue.Duration = duration;
                }

                

                var newAssignee = model.Users.Where(s => s.UserName == model.IssueAssigneeNameDto).SingleOrDefault();
                if (newAssignee is not null)
                {
                    model.ActualIssue.Assignee = newAssignee;
                    model.ActualIssue.AssigneeId = newAssignee.Id;
                }

                if (model.IssueDescriptionDto is not null)
                {
                    model.ActualIssue.Description = model.IssueDescriptionDto;
                }

                _context.Update(model.ActualIssue);
                await _context.SaveChangesAsync();
                model.isAfterEdit = true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IssueExists(model.ActualIssue.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return View(model);
        }
        return View(model);
    }








    // GET: Issue/Delete/5
    [HttpGet("Delete/{id:int}")]
    [Authorize]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var issue = await _context.Issues.FirstOrDefaultAsync(m => m.Id == id);
        if (issue == null)
        {
            return NotFound();
        }

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
            Users = await users.ToListAsync(),
            OpenIssues = await issues.Where(i => i.Status.Id == 1).ToListAsync(),
            InProgressIssues = await issues.Where(i => i.Status.Id == 2).ToListAsync(),
            DoneIssues = await issues.Where(i => i.Status.Id == 3).ToListAsync(),
            LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName,
            LoggedUserLastName = allUsers.SingleOrDefault()?.LastName,
            LoggedUserId = allUsers.SingleOrDefault()?.Id,
            LoggedUser = allUsers.SingleOrDefault(),
            Statuses = await statuses.ToListAsync()
        };


        var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
        var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
        model.LoggedUser.Role = loggedUser_Role;

        return RedirectToAction("Index", "Issue");
    }

    // POST: Issue/Delete/5
    [HttpPost("Delete/{id:int}")]
    [ValidateAntiForgeryToken]
    [Authorize]
    public async Task<IActionResult> Delete(int id)
    {
        var issue = await _context.Issues.FindAsync(id);
        if (issue.isProject)
        {
            var childrenIssues = from i in _context.Issues
                                 where i.ParentId == id
                                 select i;
            List<Issue> children = childrenIssues.ToList();
            foreach (var child in children)
            {
                _context.Issues.Remove(child);
            }
        }
        _context.Issues.Remove(issue);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index", "Issue");
    }









    // GET: Issue/Create
    [HttpGet("Create")]
    [Authorize]
    public async Task<IActionResult> Create()
    {
        var allUsers = from aU in _context.Users
                       where aU.Email == User.Identity.Name
                       select aU;
        var issues = from i in _context.Issues
                     select i;
        var users = from u in _context.Users
                    select u;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        IndexModel model = new()
        {
            Issues = await issues.Where(i => i.isProject == false).ToListAsync(),
            Projects = await issues.Where(p => p.isProject == true).ToListAsync(),
            Users = await users.ToListAsync(),
            LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName,
            LoggedUserLastName = allUsers.SingleOrDefault()?.LastName,
            LoggedUserId = allUsers.SingleOrDefault()?.Id,
            LoggedUser = allUsers.SingleOrDefault()
        };


        var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
        var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
        model.LoggedUser.Role = loggedUser_Role;

        if (model.isAfterCreate is null)
        {
            model.isAfterCreate = false;
        }
        return View(model);
    }



    // POST: Issue/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost("Create")]
    [ValidateAntiForgeryToken]
    [Authorize]
    public async Task<IActionResult> Create([Bind("IssueNameDto", "IssueParentIdDto", "IssueStatusNameDto", "IssueStartDateDto", "IssueEndDateDto", "IssueAssigneeNameDto", "IssueDescriptionDto")] IndexModel model)
    {
        {
            var allUsers = from aU in _context.Users
                           where aU.Email == User.Identity.Name
                           select aU;
            var users = from u in _context.Users
                        select u;
            var issues = from i in _context.Issues
                         select i;
            var statuses = from s in _context.Statuses
                           select s;
            var roles = from r in _context.Roles
                        select r;
            var userRoles = from uR in _context.UserRoles
                            select uR;
            model.Users = await users.ToListAsync();
            model.Projects = await issues.Where(i => i.isProject == true).ToListAsync();
            model.Statuses = await statuses.ToListAsync();
            model.LoggedUser = allUsers.SingleOrDefault();

            var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
            var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
            model.LoggedUser.Role = loggedUser_Role;

        }


        int year, month, day;
        year = month = day = 0;

        DateTime startDate;
        if (model.IssueStartDateDto == null) { startDate = DateTime.Now; }
        else
        {
            int.TryParse(model.IssueStartDateDto.Substring(0, 4), out year);
            int.TryParse(model.IssueStartDateDto.Substring(5, 2), out month);
            int.TryParse(model.IssueStartDateDto.Substring(8, 2), out day);
            startDate = new DateTime(year, month, day);
        }

        DateTime endDate;
        if (model.IssueEndDateDto == null) { endDate = DateTime.Now; }
        else
        {
            int.TryParse(model.IssueEndDateDto.Substring(0, 4), out year);
            int.TryParse(model.IssueEndDateDto.Substring(5, 2), out month);
            int.TryParse(model.IssueEndDateDto.Substring(8, 2), out day);
            endDate = new DateTime(year, month, day);
        }

        int duration = 1;
        TimeSpan interval = endDate - startDate;
        duration = interval.Days;

        Status status = model.Statuses.Where(s => s.Name == model.IssueStatusNameDto).SingleOrDefault();

        Issue parent = model.Projects.Where(s => s.Id == model.IssueParentIdDto).SingleOrDefault();

        ApplicationUser assignee = model.Users.Where(s => s.UserName == model.IssueAssigneeNameDto).SingleOrDefault();

        if (model.IssueDescriptionDto is null) { model.IssueDescriptionDto = ""; }

        if (model.IssueNameDto is null) { model.IssueNameDto = ""; }

        Issue issue = new Issue();

        if (ModelState.IsValid)
        {
            issue = new Issue(model.IssueNameDto, startDate, endDate, duration, model.IssueDescriptionDto, status, parent, assignee);
            issue.isProject = false;
            _context.Add(issue);
            await _context.SaveChangesAsync();
            model.isAfterCreate = true;
        }


        //return RedirectToAction("Details", "Issue", new { id = issue.Id });
        return View(model);
    }



    private bool IssueExists(int id)
    {
        return _context.Issues.Any(e => e.Id == id);
    }





    // POST: Issue/Search
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost("Search")]
    [ValidateAntiForgeryToken]
    [Authorize]
    public async Task<IActionResult> Search([Bind("SearchText")] IndexModel model)
    {
        return Redirect("https://www.google.com/search?q=" + Encoding.ASCII.GetString(
                     Encoding.GetEncoding("Cyrillic").GetBytes(model.SearchText)));
    }
}