using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class LocationMaster
{
    public int LocationId { get; set; }

    public string Location { get; set; } = null!;

    public virtual ICollection<UserMaster> UserMasters { get; set; } = new List<UserMaster>();
}
