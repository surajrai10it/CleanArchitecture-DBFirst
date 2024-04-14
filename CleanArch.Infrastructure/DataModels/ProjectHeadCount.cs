using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProjectHeadCount
{
    public long RowId { get; set; }

    public int UserId { get; set; }

    public int BuId { get; set; }

    public int ProductId { get; set; }

    public int DepartmentId { get; set; }

    public int TeamId { get; set; }

    public string? ProjectName { get; set; }

    public int ActualAllocation { get; set; }

    public int PlannedAllocation { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public string? Comment { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int? UpdatedBy { get; set; }
}
