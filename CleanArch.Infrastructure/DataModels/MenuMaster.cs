using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class MenuMaster
{
    public int MenuId { get; set; }

    public string MenuName { get; set; } = null!;

    public int? ParentId { get; set; }

    public string? MenuUrl { get; set; }
}
