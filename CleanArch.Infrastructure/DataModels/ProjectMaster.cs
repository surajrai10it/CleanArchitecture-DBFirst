using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProjectMaster
{
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

    public bool IsApproved { get; set; }

    public bool IsColumnUpdate { get; set; }

    public bool IsSendForApproval { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsReject { get; set; }

    public int? ApproveRejectBy { get; set; }

    public DateTime? ApproveRejectAt { get; set; }

    public bool IsDropRequest { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<ProjectResourceMapping> ProjectResourceMappings { get; set; } = new List<ProjectResourceMapping>();
}
