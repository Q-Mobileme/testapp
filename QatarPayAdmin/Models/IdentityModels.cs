using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace QatarPayAdmin.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public string IDCardNumber { get; set; }
        public string PassportNumber { get; set; }
        public int CountryID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserStatusID { get; set; }
        public string UserCode { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsPinVerified { get; set; }
        public DateTime PinVerifiedDate { get; set; }
        public bool IsIDVerified { get; set; }
        public DateTime IDVerifiedDate { get; set; }

        public DateTime IDExpiredDate { get; set; }
        public DateTime EmailVerifiedDate { get; set; }
        public DateTime PhoneVerifiedDate { get; set; }

        public string ProfileImagePath { get; set; }
        public string DigitalSignature { get; set; }

        public int UserType { get; set; }
        public DateTime QpanExpiry { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
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