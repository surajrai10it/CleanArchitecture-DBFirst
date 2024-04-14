using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class DepartmentMaster
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<TeamMaster> TeamMasters { get; set; } = new List<TeamMaster>();

    public virtual ICollection<UserMaster> UserMasters { get; set; } = new List<UserMaster>();
}
