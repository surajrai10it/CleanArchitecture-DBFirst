using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProjectVersionMaster
{
    public int RowId { get; set; }

    public int VersionId { get; set; }

    public int ProjectId { get; set; }

    public string ProjectName { get; set; } = null!;

    public string? ProjectDesc { get; set; }

    public int ProjectYear { get; set; }

    public int BuId { get; set; }

    public int ProductId { get; set; }

    public int DepartmentId { get; set; }

    public int TeamId { get; set; }

    public int ProjectTypeId { get; set; }

    public string ConfirmStatus { get; set; } = null!;

    public DateTime? IpcsPlanDate { get; set; }

    public DateTime? IpcsActualDate { get; set; }

    public DateTime? ProjectPlanDate { get; set; }

    public DateTime? ProjectActualDate { get; set; }

    public int? ProjectStatusId { get; set; }

    public int Hod { get; set; }

    public int Tl { get; set; }

    public int Pm { get; set; }

    public int Qa { get; set; }

    public string CustomerName { get; set; } = null!;

    public DateTime? KickOffPlanDate { get; set; }

    public DateTime? KickOffActualDate { get; set; }

    public int? KickOffStatusId { get; set; }

    public DateTime? PmpPlanDate { get; set; }

    public DateTime? PmpActualDate { get; set; }

    public int? PmpStatusId { get; set; }

    public string? Remarks { get; set; }

    public decimal? NewResourceCount { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public virtual ICollection<ProjectVersionResourceMapping> ProjectVersionResourceMappings { get; set; } = new List<ProjectVersionResourceMapping>();

    public virtual VersionMaster Version { get; set; } = null!;
}
