using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProjectHistory
{
    public int HistoryId { get; set; }

    public int ProjectId { get; set; }

    public string? Description { get; set; }

    public string? FromValue { get; set; }

    public string? ToValue { get; set; }

    public DateTime ActionAt { get; set; }

    public int ActionBy { get; set; }
}
