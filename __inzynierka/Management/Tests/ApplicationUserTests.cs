using Management.Models;
using Microsoft.AspNetCore.Identity;
using System;
using Xunit;

namespace Tests
{
    public class ApplicationUserTests
    {
        [Fact]
        public void AddingExtraData()
        {
            string firstName = "Jan";
            string lastName = "Kowalski";
            string roleName = "W³aœciciel";
            IdentityRole role = new IdentityRole(roleName);

            ApplicationUser au = new ApplicationUser();
            au.FirstName = firstName;
            au.LastName = lastName;
            au.Role = role;

            Assert.Equal(firstName, au.FirstName);
            Assert.Equal(lastName, au.LastName);
            Assert.Equal(roleName, role.Name);
            Assert.Equal(roleName, au.Role.Name);
            Assert.Equal(role, au.Role);
        }
    }
}