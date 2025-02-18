using System;
using System.Collections.Generic;

namespace EF_1_DatabaseFirst.Entities;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
