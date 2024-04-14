using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class DesignationMaster
{
    public int DesignationId { get; set; }

    public string DesignationName { get; set; } = null!;

    public virtual ICollection<UserMaster> UserMasters { get; set; } = new List<UserMaster>();
}
