using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class MainVersionMaster
{
    public int MVersionId { get; set; }

    public int MVersion { get; set; }

    public int Year { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }

    public virtual ICollection<MainSubVersionMapping> MainSubVersionMappings { get; set; } = new List<MainSubVersionMapping>();
}
