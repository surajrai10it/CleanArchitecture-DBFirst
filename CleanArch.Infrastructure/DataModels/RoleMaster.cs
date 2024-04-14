using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class RoleMaster
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserMaster> UserMasters { get; set; } = new List<UserMaster>();
}
