using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class MasterVersionHeadCount
{
    public long MasterVersionRowId { get; set; }

    public int VersionNo { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }
}
