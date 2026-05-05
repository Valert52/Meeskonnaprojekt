using Microsoft.EntityFrameworkCore;
using Abc.Data;
using Abc.Data.Consultation;

namespace Abc.Infra;

public class AbcSoftMoviesContext(DbContextOptions<AbcSoftMoviesContext> options)
    : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; } = default!;
    public DbSet<Country> Countries { get; set; } = default!;
    public DbSet<Currency> Currencies { get; set; } = default!;
    public DbSet<Money> Money { get; set; } = default!;
    public DbSet<CountryCurrency> CountryCurrencies { get; set; } = default!;
    public DbSet<Course> Courses { get; set; } = default!;
    public DbSet<Material> Materials { get; set; } = default!;
    public DbSet<CourseMaterial> CourseMaterials { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder b)
    {
        base.OnModelCreating(b);
        b.ApplyConfigurationsFromAssembly(typeof(AbcSoftMoviesContext).Assembly);
    }
}