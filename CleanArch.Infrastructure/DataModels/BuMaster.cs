using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class BuMaster
{
    public int BuId { get; set; }

    public string BuName { get; set; } = null!;

    public virtual ICollection<ProductMaster> ProductMasters { get; set; } = new List<ProductMaster>();
}
