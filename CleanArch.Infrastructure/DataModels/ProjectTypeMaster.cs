using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class ProjectTypeMaster
{
    public int ProjectTypeId { get; set; }

    public string ProjectType { get; set; } = null!;
}
