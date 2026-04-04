using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Abc.Data;

public class Money : BaseEntity
{
    public decimal Amount { get; set; }
    public int? CurrencyId { get; set; }
    public Currency Currency { get; set;  }
}