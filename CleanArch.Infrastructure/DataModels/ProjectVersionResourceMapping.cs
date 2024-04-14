using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProjectVersionResourceMapping
{
    public int ProjectResourceId { get; set; }

    public int RowId { get; set; }

    public int ProjectId { get; set; }

    public int UserId { get; set; }

    public int Availability { get; set; }

    public bool IsNewUser { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public virtual ProjectVersionMaster Row { get; set; } = null!;
}
