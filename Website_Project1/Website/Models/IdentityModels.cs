using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Website.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public System.DateTime DateOfRegister { get; set; }
        public string Nationality { get; set; }
        public bool IsPromotion { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public string Ratings { get; set; }
        public string Subject { get; set; }
        public string Experience { get; set; }
        public string Photo { get; set; }
        public string Certificate { get; set; }
        public DateTime AllowDays { get; set; }
        public string ReferalLink { get; set; }
        public string Bio { get; set; }
        public int UserId { get; set; }
        public string Achievements { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        { 
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}