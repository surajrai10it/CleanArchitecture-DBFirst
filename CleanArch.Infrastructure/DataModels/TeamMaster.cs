using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class TeamMaster
{
    public int TeamId { get; set; }

    public int DepartmentId { get; set; }

    public string TeamName { get; set; } = null!;

    public virtual DepartmentMaster Department { get; set; } = null!;
}
