using Microsoft.EntityFrameworkCore;
using Abc.Data;

namespace Abc.Infra;

public class AbcSoftMoviesContext(DbContextOptions<AbcSoftMoviesContext> options)
    : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; } = default!;
    public DbSet<Country> Countries { get; set; } = default!;
    public DbSet<Currency> Currencies { get; set; } = default!;
    public DbSet<Money> Money { get; set; } = default!;
    public DbSet<CountryCurrency> CountryCurrencies { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder b)
    {
        base.OnModelCreating(b);
        b.ApplyConfigurationsFromAssembly(typeof(AbcSoftMoviesContext).Assembly);
    }
}