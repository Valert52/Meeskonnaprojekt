using Abc.Data;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra;

public class MoviesRepo(AbcSoftMoviesContext c = null)
    : EfBaseRepo<AbcSoftMoviesContext, Movie>(c), IMoviesRepo
{ }
public class CurrenciesRepo(AbcSoftMoviesContext c = null)
    : EfBaseRepo<AbcSoftMoviesContext, Currency>(c), ICurrenciesRepo
{ }
public class CountriesRepo(AbcSoftMoviesContext c = null)
    : EfBaseRepo<AbcSoftMoviesContext, Country>(c), ICountriesRepo
{
    protected override IQueryable<Country> Query() => db.Countries
        .Include(x => x.CountryCurrencies)
        .ThenInclude(x => x.Currency);
}
public class MoneyRepo(AbcSoftMoviesContext c = null)
    : EfBaseRepo<AbcSoftMoviesContext, Money>(c), IMoneyRepo
{ }
public class CountryCurrenciesRepo(AbcSoftMoviesContext c = null)
    : EfBaseRepo<AbcSoftMoviesContext, CountryCurrency>(c), ICountryCurrenciesRepo
{
    protected override IQueryable<CountryCurrency> Query() => db.CountryCurrencies
        .Include(x => x.Country)
        .Include(x => x.Currency);
}