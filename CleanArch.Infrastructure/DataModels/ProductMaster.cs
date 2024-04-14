using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProductMaster
{
    public int ProductId { get; set; }

    public int BuId { get; set; }

    public string ProductName { get; set; } = null!;

    public virtual BuMaster Bu { get; set; } = null!;
}
