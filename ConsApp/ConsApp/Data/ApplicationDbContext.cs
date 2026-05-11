using Abc.Data.Consultation;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConsApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<User> ConsultationUsers { get; set; }
        public DbSet<Role> ConsultationRoles { get; set; }
        public DbSet<UserRole> ConsultationUserRoles { get; set; }
    }
}