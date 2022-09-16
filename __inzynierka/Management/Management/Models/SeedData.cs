using Management.Data;
using Management.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Management.Models
{
    public static class SeedData
    {
        public static async void InitializeRoles(IServiceProvider serviceProvider)
        {
            bool con1 = true;
            bool con2 = true;
            IdentityRole adminRole = new()
            {
                Name = "Admin",
                NormalizedName = "Admin"
            };
            IdentityRole managerRole = new()
            {
                Name = "Manager",
                NormalizedName = "Manager"
            };
            IdentityRole userRole = new()
            {
                Name = "User",
                NormalizedName = "User"
            };
            ApplicationUser admin0 = new()
            {
                UserName = "Unassigned",
                Email = "Unassigned",
                NormalizedEmail = "UNASSIGNED",
                NormalizedUserName = "UNASSIGNED",
                FirstName = "Unassigned",
                LastName = "",
                EmailConfirmed = true,
                Role = managerRole
            };
            ApplicationUser admin1 = new()
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                FirstName = "Admin",
                LastName = "Adminowski",
                EmailConfirmed = true,
                Role = adminRole
            };
            ApplicationUser user2 = new()
            {
                UserName = "q@q.q",
                Email = "q@q.q",
                NormalizedEmail = "Q@Q.Q",
                NormalizedUserName = "Q@Q.Q",
                FirstName = "Jan",
                LastName = "Kowalski",
                EmailConfirmed = true,
                Role = userRole
            };
            ApplicationUser user3 = new()
            {
                UserName = "w@w.w",
                Email = "w@w.w",
                NormalizedEmail = "W@W.W",
                NormalizedUserName = "W@W.W",
                FirstName = "Marcin",
                LastName = "Nowak",
                EmailConfirmed = true,
                Role = userRole
            };
            ApplicationUser user4 = new()
            {
                UserName = "a@a.a",
                Email = "a@a.a",
                NormalizedEmail = "A@A.A",
                NormalizedUserName = "A@A.A",
                FirstName = "Tomasz",
                LastName = "Kowalczyk",
                EmailConfirmed = true,
                Role = userRole
            };
            string password = "P@ssw0rd";
            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            string passwordHashed = hasher.HashPassword(admin1, password);
            admin1.PasswordHash = passwordHashed;

            passwordHashed = hasher.HashPassword(user2, password);
            user2.PasswordHash = passwordHashed;

            passwordHashed = hasher.HashPassword(user3, password);
            user3.PasswordHash = passwordHashed;

            passwordHashed = hasher.HashPassword(user4, password);
            user4.PasswordHash = passwordHashed;

            Status open = new("Open");
            Status inProgress = new("In Progress");
            Status done = new("Done");


            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                //Looks if data are seed before
                if (context.Roles.Any())
                {
                    con1 = false;
                }

                if (con1)
                {
                    context.Roles.AddRange(adminRole, managerRole, userRole);

                    context.Users.AddRange(admin0, admin1, user2, user3, user4);

                    context.UserRoles.AddRange(
                        new IdentityUserRole<string>
                        {
                            UserId = admin0.Id,
                            RoleId = managerRole.Id
                        },
                        new IdentityUserRole<string>
                        {
                            UserId = admin1.Id,
                            RoleId = adminRole.Id
                        },
                        new IdentityUserRole<string>
                        {
                            UserId = user2.Id,
                            RoleId = userRole.Id
                        },
                        new IdentityUserRole<string>
                        {
                            UserId = user3.Id,
                            RoleId = userRole.Id
                        },
                        new IdentityUserRole<string>
                        {
                            UserId = user4.Id,
                            RoleId = userRole.Id
                        }
                        );
                }
                else return;

                context.SaveChanges();
            }
            using (var context = new ApplicationDbContext(
              serviceProvider.GetRequiredService<
                  DbContextOptions<ApplicationDbContext>>()))
            {
                //Looks if data are seed before
                if (context.Statuses.Any())
                {
                    con2 = false;
                }

                if (con2) { context.Statuses.AddRange(open, inProgress, done); }

                context.SaveChanges();
            }
        }
    }
}
