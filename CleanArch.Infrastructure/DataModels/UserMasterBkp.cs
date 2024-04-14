using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class UserMasterBkp
{
    public int UserId { get; set; }

    public string? EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string? Password { get; set; }

    public string EmpEmail { get; set; } = null!;

    public DateTime? Doj { get; set; }

    public int EmployementId { get; set; }

    public string? Part { get; set; }

    public int LocationId { get; set; }

    public int RoleId { get; set; }

    public int DesignationId { get; set; }

    public int DepartmentId { get; set; }

    public int? TeamId { get; set; }

    public int Manager { get; set; }

    public bool IsNewUser { get; set; }

    public string? Remarks { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
