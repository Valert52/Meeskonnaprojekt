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
        public DbSet<Abc.Data.Consultation.BookingPage> BookingPage { get; set; } = default!;
        public DbSet<Abc.Data.Consultation.ConsultationSlot> ConsultationSlot { get; set; } = default!;
    }
}