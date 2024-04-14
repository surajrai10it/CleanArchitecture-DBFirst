using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class StatusMaster
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;
}
