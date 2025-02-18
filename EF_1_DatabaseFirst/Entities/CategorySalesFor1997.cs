using System;
using System.Collections.Generic;

namespace EF_1_DatabaseFirst.Entities;

public partial class CategorySalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public decimal? CategorySales { get; set; }
}
