using Microsoft.AspNetCore.Identity;

namespace Management.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IdentityRole? Role { get; set; }
    }
}
