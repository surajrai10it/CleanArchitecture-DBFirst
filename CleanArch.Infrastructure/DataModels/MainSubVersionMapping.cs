using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class MainSubVersionMapping
{
    public int RowId { get; set; }

    public int MVersionId { get; set; }

    public int VersionId { get; set; }

    public virtual MainVersionMaster MVersion { get; set; } = null!;

    public virtual VersionMaster Version { get; set; } = null!;
}
