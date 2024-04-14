using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class QaMaster
{
    public int QaId { get; set; }

    public string QaName { get; set; } = null!;

    public int QaEmpId { get; set; }
}
