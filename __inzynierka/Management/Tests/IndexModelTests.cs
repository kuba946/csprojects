using Management.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class IndexModelTests
    {
        [Fact]
        public void IndexModelObject()
        {
            string searchText = "search text";
            Issue project = new Issue("projekt", DateTime.Now, DateTime.Now, 0, "opis", new Status("Open"), null, new ApplicationUser());
            Issue issue = new Issue("zadanie", DateTime.Now, DateTime.Now, 0, "opis", new Status("Open"), project, new ApplicationUser());
            List<Issue> issues = new List<Issue>() { issue };
            List<Issue> projects = new List<Issue> { project };
            Issue actualIssue = new Issue("zadanie");
            List<Issue> openIssues = new List<Issue>() { actualIssue, issue, project };
            List<Issue> inProgressIssues = new List<Issue>() { actualIssue, issue, project };
            List<Issue> doneIssues = new List<Issue>() { actualIssue, issue, project };
            List<Status> statuses = new List<Status>() { new Status("Open"), new Status("In Progress"),  new Status("Done") };
            List<ApplicationUser> users = new List<ApplicationUser>() { new ApplicationUser() };
            string loggedUserFirstName = "loggedUserFirstName";
            string loggedUserLastName = "loggedUserLastName";
            string loggedUserId = "loggedUserId";
            ApplicationUser loggedUser = new ApplicationUser();

            string issueNameDto = "issueNameDto";
            string issueParentNameDto = "issueParentNameDto";
            int issueParentIdDto = 2;
            string issueStatusNameDto = "issueStatusNameDto";
            string issueStartDateDto = "issueStartDateDto";
            string issueEndDateDto = "issueEndDateDto";
            string issueAssigneeNameDto = "issueAssigneeNameDto";
            string issueDescriptionDto = "issueDescriptionDto";
            bool isAfterEdit = true;
            bool isAfterCreate = false;
            List<IdentityRole> roles = new List<IdentityRole> { new IdentityRole() };

            IndexModel model = new IndexModel();


            model.SearchText = searchText;
            model.Issues = issues;
            model.Projects = projects;
            model.ActualIssue = actualIssue;
            model.OpenIssues = openIssues;
            model.InProgressIssues = inProgressIssues;
            model.DoneIssues = doneIssues;
            model.Statuses = statuses;
            model.Users = users;
            model.LoggedUserFirstName = loggedUserFirstName;
            model.LoggedUserLastName = loggedUserLastName;
            model.LoggedUserId = loggedUserId;
            model.LoggedUser = loggedUser;

            model.IssueNameDto = issueNameDto;
            model.IssueParentNameDto = issueParentNameDto;
            model.IssueParentIdDto = issueParentIdDto;
            model.IssueStatusNameDto = issueStatusNameDto;
            model.IssueStartDateDto = issueStartDateDto;
            model.IssueEndDateDto = issueEndDateDto;
            model.IssueAssigneeNameDto = issueAssigneeNameDto;
            model.IssueDescriptionDto = issueDescriptionDto;
            model.isAfterEdit = isAfterEdit;
            model.isAfterCreate = isAfterCreate;
            model.Roles = roles;

            Assert.Equal(model.SearchText, searchText);
            Assert.Equal(model.Issues, issues);
            Assert.Equal(model.Projects, projects);
            Assert.Equal(model.ActualIssue, actualIssue);
            Assert.Equal(model.OpenIssues, openIssues);
            Assert.Equal(model.InProgressIssues, inProgressIssues);
            Assert.Equal(model.DoneIssues, doneIssues);
            Assert.Equal(model.Statuses, statuses);
            Assert.Equal(model.Users, users);
            Assert.Equal(model.LoggedUserFirstName, loggedUserFirstName);
            Assert.Equal(model.LoggedUserLastName, loggedUserLastName);
            Assert.Equal(model.LoggedUserId, loggedUserId);
            Assert.Equal(model.LoggedUser, loggedUser);

            Assert.Equal(model.IssueNameDto, issueNameDto);
            Assert.Equal(model.IssueParentNameDto, issueParentNameDto);
            Assert.Equal(model.IssueParentIdDto, issueParentIdDto);
            Assert.Equal(model.IssueStatusNameDto, issueStatusNameDto);
            Assert.Equal(model.IssueStartDateDto, issueStartDateDto);
            Assert.Equal(model.IssueEndDateDto, issueEndDateDto);
            Assert.Equal(model.IssueAssigneeNameDto, issueAssigneeNameDto);
            Assert.Equal(model.IssueDescriptionDto, issueDescriptionDto);
            Assert.Equal(model.isAfterEdit, isAfterEdit);
            Assert.Equal(model.isAfterCreate, isAfterCreate);
            Assert.Equal(model.Roles, roles);
        }

        [Fact]
        public void AdminUserDtoObject()
        {
            Issue project = new Issue("projekt", DateTime.Now, DateTime.Now, 0, "opis", new Status("Open"), null, new ApplicationUser());
            Issue issue = new Issue("zadanie", DateTime.Now, DateTime.Now, 0, "opis", new Status("Open"), project, new ApplicationUser());

            List<Issue> OpenIssues = new List<Issue>() { project, issue };
            List<Issue> InProgressIssues = new List<Issue>() { project, issue };
            List<Issue> DoneIssues = new List<Issue>() { project, issue };
            List<Status> Statuses = new List<Status>() { new Status("Open"), new Status("In Progress"), new Status("Done") };

            string LoggedUserFirstName = "LoggedUserFirstName";
            string LoggedUserLastName = "LoggedUserLastName";
            string LoggedUserId = "LoggedUserId";
            ApplicationUser LoggedUser = new ApplicationUser();
            List<ApplicationUser> Users = new List<ApplicationUser>() { LoggedUser };
            bool isAfterEdit = true;
            bool isAfterCreate = false;

            ApplicationUser ActualUser = new ApplicationUser();
            List<IdentityRole> Roles = new List<IdentityRole>() { new IdentityRole("Admin"), new IdentityRole("Manager"), new IdentityRole("User") };
            string AdminUserIdDto = "AdminUserIdDto";
            bool isUserNameFree = true;
            string AdminUserNameDto = "AdminUserNameDto";
            string AdminUserFirstNameDto = "AdminUserFirstNameDto";
            string AdminUserLastNameDto = "AdminUserLastNameDto";
            string AdminUserRoleIdDto = "AdminUserRoleIdDto";
            string AdminUserPassword = "AdminUserPassword";
            string AdminUserConfirmPassword = "AdminUserConfirmPassword";

            AdminUserDto model = new AdminUserDto();



            model.OpenIssues = OpenIssues;
            model.InProgressIssues = InProgressIssues;
            model.DoneIssues = DoneIssues;
            model.Statuses = Statuses;

            model.LoggedUserFirstName = LoggedUserFirstName;
            model.LoggedUserLastName = LoggedUserLastName;
            model.LoggedUserId = LoggedUserId;
            model.LoggedUser = LoggedUser;
            model.Users = Users;
            model.isAfterEdit = isAfterEdit;
            model.isAfterCreate = isAfterCreate;

            model.ActualUser = ActualUser;
            model.Roles = Roles;
            model.AdminUserIdDto = AdminUserIdDto;
            model.isUserNameFree = isUserNameFree;
            model.AdminUserNameDto = AdminUserNameDto;
            model.AdminUserFirstNameDto = AdminUserFirstNameDto;
            model.AdminUserLastNameDto = AdminUserLastNameDto;
            model.AdminUserRoleIdDto = AdminUserRoleIdDto;
            model.AdminUserPassword = AdminUserPassword;
            model.AdminUserConfirmPassword = AdminUserConfirmPassword;





            Assert.Equal(model.OpenIssues, OpenIssues);
            Assert.Equal(model.InProgressIssues, InProgressIssues);
            Assert.Equal(model.DoneIssues, DoneIssues);
            Assert.Equal(model.Statuses, Statuses);

            Assert.Equal(model.LoggedUserFirstName, LoggedUserFirstName);
            Assert.Equal(model.LoggedUserLastName, LoggedUserLastName);
            Assert.Equal(model.LoggedUserId, LoggedUserId);
            Assert.Equal(model.LoggedUser, LoggedUser);
            Assert.Equal(model.Users, Users);
            Assert.Equal(model.isAfterEdit, isAfterEdit);
            Assert.Equal(model.isAfterCreate, isAfterCreate);

            Assert.Equal(model.ActualUser, ActualUser);
            Assert.Equal(model.Roles, Roles);
            Assert.Equal(model.AdminUserIdDto, AdminUserIdDto);
            Assert.Equal(model.isUserNameFree, isUserNameFree);
            Assert.Equal(model.AdminUserNameDto, AdminUserNameDto);
            Assert.Equal(model.AdminUserFirstNameDto, AdminUserFirstNameDto);
            Assert.Equal(model.AdminUserLastNameDto, AdminUserLastNameDto);
            Assert.Equal(model.AdminUserRoleIdDto, AdminUserRoleIdDto);
            Assert.Equal(model.AdminUserPassword, AdminUserPassword);
            Assert.Equal(model.AdminUserConfirmPassword, AdminUserConfirmPassword);
        }
    }
}