using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProjectResourceMapping
{
    public int ProjectResourceId { get; set; }

    public int ProjectId { get; set; }

    public int UserId { get; set; }

    public int Availability { get; set; }

    public bool IsNewUser { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public virtual ProjectMaster Project { get; set; } = null!;
}
