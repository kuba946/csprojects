using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Management.Models
{
    public class IndexModel
    {
        public string? SearchText { get; set; }
        public List<Issue>? Issues { get; set; }
        public List<Issue>? Projects { get; set; }
        public Issue? ActualIssue { get; set; }
        public List<Issue>? OpenIssues { get; set; }
        public List<Issue>? InProgressIssues { get; set; }
        public List<Issue>? DoneIssues { get; set; }
        public List<Status>? Statuses { get; set; }
        public List<ApplicationUser>? Users { get; set; }
        public string? LoggedUserFirstName { get; set; }
        public string? LoggedUserLastName { get; set; }
        public string? LoggedUserId { get; set; }
        public ApplicationUser? LoggedUser { get; set; }

        /// <summary>
        /// DTO for Issue / Project CRUD
        /// </summary>
        public string? IssueNameDto { get; set; }
        public string? IssueParentNameDto { get; set; }
        public int? IssueParentIdDto { get; set; }
        public string? IssueStatusNameDto { get; set; }
        public string? IssueStartDateDto { get; set; }
        public string? IssueEndDateDto { get; set; }
        public string? IssueAssigneeNameDto { get; set; }
        public string? IssueDescriptionDto { get; set; }
        public bool? isAfterEdit { get; set; }
        public bool? isAfterCreate { get; set; }
        public List<IdentityRole>? Roles { get; set; }


    }
    public class AdminUserDto
    {

        //public string? SearchText { get; set; }
        //public List<Issue>? Issues { get; set; }
        public List<Issue>? OpenIssues { get; set; }
        public List<Issue>? InProgressIssues { get; set; }
        public List<Issue>? DoneIssues { get; set; }
        public List<Status>? Statuses { get; set; }


        public string? LoggedUserFirstName { get; set; }
        public string? LoggedUserLastName { get; set; }
        public string? LoggedUserId { get; set; }
        public ApplicationUser? LoggedUser { get; set; }
        public List<ApplicationUser>? Users { get; set; }
        public bool? isAfterEdit { get; set; }
        public bool? isAfterCreate { get; set; }


        /// <summary>
        /// DTO for AdminUser
        /// </summary>
        public ApplicationUser? ActualUser { get; set; }
        public List<IdentityRole>? Roles { get; set; }
        public string? AdminUserIdDto { get; set; }

        public bool isUserNameFree { get; set; } = true;

        //[Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string? AdminUserNameDto { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Cannot be empty.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string? AdminUserFirstNameDto { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Cannot be empty.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string? AdminUserLastNameDto { get; set; }
        public string? AdminUserRoleIdDto { get; set; }


        //[Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? AdminUserPassword { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Confirmation Password")]
        [Compare("AdminUserPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string? AdminUserConfirmPassword { get; set; }
    }
}
