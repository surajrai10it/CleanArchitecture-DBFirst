using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class VersionMaster
{
    public int VersionId { get; set; }

    public int DepartmentId { get; set; }

    public int Year { get; set; }

    public decimal VersionNo { get; set; }

    public string VersionName { get; set; } = null!;

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public virtual ICollection<MainSubVersionMapping> MainSubVersionMappings { get; set; } = new List<MainSubVersionMapping>();

    public virtual ICollection<ProjectVersionMaster> ProjectVersionMasters { get; set; } = new List<ProjectVersionMaster>();
}
