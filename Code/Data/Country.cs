using Abc.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Abc.Data;

public sealed class Country : NamedEntity
{
    public string OfficialName { get; set; } = "";
    public string NativeName { get; set; } = "";
    public string NumericCode { get; set; } = "";
    public bool IsCountry { get; set; }
    public bool IsLoyaltyProgram { get; set; }
    public string IsoCode { get; set; } = "";
    public string Capital { get; set; } = "";
    public IEnumerable<CountryCurrency> Currencies { get; set; } = [];
}