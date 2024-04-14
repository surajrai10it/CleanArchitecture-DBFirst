using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class DeptVersionHeadCount
{
    public long RowId { get; set; }

    public int? MasterVersionRowId { get; set; }

    public int DepartementId { get; set; }

    public int VersionNo { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }
}
