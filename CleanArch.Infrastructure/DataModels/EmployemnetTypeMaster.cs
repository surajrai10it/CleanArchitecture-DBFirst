using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class EmployemnetTypeMaster
{
    public int EmployementId { get; set; }

    public string EmploymentTypeName { get; set; } = null!;

    public virtual ICollection<UserMaster> UserMasters { get; set; } = new List<UserMaster>();
}
