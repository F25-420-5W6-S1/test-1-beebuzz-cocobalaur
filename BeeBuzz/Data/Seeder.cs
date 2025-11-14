using BeeBuzz.Data;
using Microsoft.AspNetCore.Identity;
using BeeBuzz.Data.Entities;
using System.Text.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace BeeBuzz.Data
{
    public class Seeder {

        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public Seeder(ApplicationDbContext context, RoleManager<IdentityRole<int>> roleManager, UserManager<ApplicationUser> userManager)
        {
            _db = context;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            _db.Database.EnsureCreated();


            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Default"));

            }

            if (!_db.Users.Any())
            {

                var user = new ApplicationUser()
                {
                    Organization = new Organization()
                    {
                        organizationID = "0000-0000-0000-0000",
                        uniqID = 1,

                    },
                    Role = "Admin"

                };

                _db.Add(user);

                _db.SaveChanges();  
            }
        }

    }
}

