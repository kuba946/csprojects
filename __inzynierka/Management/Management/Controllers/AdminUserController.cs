using Management.Data;
using Management.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using System.Web;

namespace Management.Controllers;

[Controller]
[Route("[controller]")]

public class AdminUserController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public AdminUserController(ILogger<HomeController> logger, ApplicationDbContext context)
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
        var users = from u in _context.Users
                    select u;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        AdminUserDto model = new()
        {
            Users = await users.ToListAsync(),
            LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName,
            LoggedUserLastName = allUsers.SingleOrDefault()?.LastName,
            LoggedUserId = allUsers.SingleOrDefault()?.Id,
            LoggedUser = allUsers.SingleOrDefault(),
            Roles = await roles.ToListAsync()
        };

        var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
        var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
        model.LoggedUser.Role = loggedUser_Role;

        foreach (var user in model.Users)
        {
            if (user.UserName != "Unassigned")
            {
                var userRole = userRoles.Where(uR => uR.UserId == user.Id).SingleOrDefault();
                var role = roles.Where(r => r.Id == userRole.RoleId).SingleOrDefault();
                user.Role = role;
            }
        }
        return View(model);
    }

    // GET: AdminUser/Details/5
    [HttpGet("Details/{id}")]
    [Authorize]
    public async Task<IActionResult> Details(string? id)
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
        var actualUser = from acUs in _context.Users
                         where acUs.Id == id
                         select acUs;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        AdminUserDto model = new()
        {
            Users = await users.ToListAsync(),
            LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName,
            LoggedUserLastName = allUsers.SingleOrDefault()?.LastName,
            LoggedUserId = allUsers.SingleOrDefault()?.Id,
            LoggedUser = allUsers.SingleOrDefault(),
            Roles = await roles.ToListAsync(),
            ActualUser = actualUser.SingleOrDefault()
        };

        var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
        var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
        model.LoggedUser.Role = loggedUser_Role;

        foreach (var user in model.Users)
        {
            if (user.UserName != "Unassigned")
            {
                var userRole = userRoles.Where(uR => uR.UserId == user.Id).SingleOrDefault();
                var role = roles.Where(r => r.Id == userRole.RoleId).SingleOrDefault();
                user.Role = role;
            }
        }
        //model.AdminUserPassword = null;
        //model.AdminUserConfirmPassword = null;
        if (model.isAfterEdit is null)
        {
            model.isAfterEdit = false;
        }
        if (actualUser == null)
        {
            return NotFound();
        }

        return View(model);
    }


    // POST: AdminUser/Details/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost("Details/{id}")]
    [ValidateAntiForgeryToken]
    [Authorize]
    public async Task<IActionResult> Details(string id, [Bind("AdminUserNameDto", "AdminUserFirstNameDto", "AdminUserLastNameDto", "AdminUserRoleIdDto", "AdminUserPassword", "AdminUserConfirmPassword")] AdminUserDto model)
    {
        var allUsers = from aU in _context.Users
                       where aU.Email == User.Identity.Name
                       select aU;
        var users = from u in _context.Users
                    select u;
        var actualUser = from acUs in _context.Users
                         where acUs.Id == id
                         select acUs;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        model.Users = await users.ToListAsync();
        model.LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName;
        model.LoggedUserLastName = allUsers.SingleOrDefault()?.LastName;
        model.LoggedUserId = allUsers.SingleOrDefault()?.Id;
        model.LoggedUser = allUsers.SingleOrDefault();
        model.Roles = await roles.ToListAsync();
        model.ActualUser = actualUser.SingleOrDefault();


        var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
        var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
        model.LoggedUser.Role = loggedUser_Role;

        foreach (var user in model.Users)
        {
            if (user.UserName != "Unassigned")
            {
                var userRole = userRoles.Where(uR => uR.UserId == user.Id).SingleOrDefault();
                var role = roles.Where(r => r.Id == userRole.RoleId).SingleOrDefault();
                user.Role = role;
            }
        }
        if (id != model.ActualUser.Id)
        {
            return NotFound();
        }
        if (ModelState.IsValid)
        {
            try
            {
                if (model.AdminUserFirstNameDto != null)
                {
                    model.ActualUser.FirstName = model.AdminUserFirstNameDto;
                }
                if (model.AdminUserLastNameDto != null)
                {
                    model.ActualUser.LastName = model.AdminUserLastNameDto;
                }

                var newRole = model.Roles.Where(r => r.Id == model.AdminUserRoleIdDto).SingleOrDefault();
                var oldUserRole = userRoles.Where(uR => uR.UserId == model.ActualUser.Id).SingleOrDefault();
                _context.UserRoles.Remove(oldUserRole);
                await _context.SaveChangesAsync();

                IdentityUserRole<string> newUserRole = new IdentityUserRole<string>();
                if (newRole is not null)
                {
                    newUserRole.UserId = model.ActualUser.Id;
                    newUserRole.RoleId = newRole.Id;
                    model.ActualUser.Role = newRole;
                }



                if (model.AdminUserPassword is not null)
                {
                    PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
                    string passwordHashed = hasher.HashPassword(model.ActualUser, model.AdminUserPassword);
                    model.ActualUser.PasswordHash = passwordHashed;
                }


                _context.UserRoles.Add(newUserRole);
                _context.Update(model.ActualUser);
                await _context.SaveChangesAsync();
                model.isAfterEdit = true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(model.ActualUser.Id))
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





    // GET: AdminUser/Create
    [HttpGet("Create")]
    [Authorize]
    public async Task<IActionResult> Create()
    {
        var allUsers = from aU in _context.Users
                       where aU.Email == User.Identity.Name
                       select aU;
        var users = from u in _context.Users
                    select u;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        AdminUserDto model = new()
        {
            Users = await users.ToListAsync(),
            LoggedUserFirstName = allUsers.SingleOrDefault()?.FirstName,
            LoggedUserLastName = allUsers.SingleOrDefault()?.LastName,
            LoggedUserId = allUsers.SingleOrDefault()?.Id,
            LoggedUser = allUsers.SingleOrDefault(),
            Roles = await roles.ToListAsync()
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





    // POST: AdminUser/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost("Create")]
    [ValidateAntiForgeryToken]
    [Authorize]
    public async Task<IActionResult> Create([Bind("AdminUserNameDto", "AdminUserFirstNameDto", "AdminUserLastNameDto", "AdminUserRoleIdDto", "AdminUserPassword", "AdminUserConfirmPassword")] AdminUserDto model)
    {
        {
            var allUsers = from aU in _context.Users
                           where aU.Email == User.Identity.Name
                           select aU;
            var users = from u in _context.Users
                        select u;
            var roles = from r in _context.Roles
                        select r;
            var userRoles = from uR in _context.UserRoles
                            select uR;
            model.Users = await users.ToListAsync();
            model.Roles = await roles.ToListAsync();
            model.LoggedUser = allUsers.SingleOrDefault();

            var loggedUser_UserRole = userRoles.Where(uR => uR.UserId == model.LoggedUser.Id).SingleOrDefault();
            var loggedUser_Role = roles.Where(r => r.Id == loggedUser_UserRole.RoleId).SingleOrDefault();
            model.LoggedUser.Role = loggedUser_Role;

        }


        ApplicationUser newUser = new ApplicationUser();
        foreach (var user in model.Users)
        {
            if (user.UserName == model.AdminUserNameDto || model.AdminUserNameDto is null)
            {
                model.isUserNameFree = false;
                return View(model);
            }
        }

        if (ModelState.IsValid)
        {
            newUser = new()
            {
                UserName = model.AdminUserNameDto,
                Email = model.AdminUserNameDto,
                NormalizedUserName = model.AdminUserNameDto.ToUpper(),
                NormalizedEmail = model.AdminUserNameDto.ToUpper(),
                FirstName = model.AdminUserFirstNameDto,
                LastName = model.AdminUserLastNameDto,
                EmailConfirmed = true,
                Role = model.Roles.Where(r => r.Id == model.AdminUserRoleIdDto).SingleOrDefault()
            };

            IdentityUserRole<string> newUserRole = new()
            {
                UserId = newUser.Id,
                RoleId = newUser.Role.Id
            };

            if (model.AdminUserPassword is not null)
            {
                PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
                string passwordHashed = hasher.HashPassword(newUser, model.AdminUserPassword);
                newUser.PasswordHash = passwordHashed;
            }


            _context.Users.Add(newUser);
            _context.UserRoles.Add(newUserRole);
            await _context.SaveChangesAsync();
            model.isAfterCreate = true;
        }
        else
        {
            return View(model);
        }

        //return RedirectToAction("Details", "AdminUser", new { id = newUser.Id } );
        return View(model);
    }





    // GET: AdminUser/Delete/5
    [HttpGet("Delete/{id}")]
    [Authorize]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
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
        AdminUserDto model = new()
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

        return RedirectToAction("Index", "Project");
    }

    // POST: AdminUser/Delete/5
    [HttpPost("Delete/{id}")]
    [ValidateAntiForgeryToken]
    [Authorize]
    public async Task<IActionResult> Delete(string id)
    {
        var unassignedUser = from anUs in _context.Users
                             where anUs.UserName == "Unassigned"
                             select anUs;
        var actualUser = from acUs in _context.Users
                         where acUs.Id == id
                         select acUs;
        var usersIssues = from i in _context.Issues
                          where i.Assignee.Id == id
                          select i;
        var roles = from r in _context.Roles
                    select r;
        var userRoles = from uR in _context.UserRoles
                        select uR;
        ApplicationUser UnassignedUser = unassignedUser.SingleOrDefault();
        ApplicationUser userToRemove = actualUser.SingleOrDefault();
        List<Issue> UsersIssues = new List<Issue>();

        UsersIssues = await usersIssues.ToListAsync();

        foreach (var item in UsersIssues)
        {
            item.Assignee = UnassignedUser;
            item.AssigneeId = UnassignedUser.Id;
        }

        _context.Users.Remove(userToRemove);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index", "AdminUser");
    }






    private bool UserExists(string id)
    {
        return _context.Users.Any(e => e.Id == id);
    }
}
