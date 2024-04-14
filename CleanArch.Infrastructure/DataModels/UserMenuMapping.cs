using System;
using System.Collections.Generic;

namespace CleanArch.Infrastructure.DataModels;

public partial class UserMenuMapping
{
    public int Id { get; set; }

    public int MenuId { get; set; }

    public int UserId { get; set; }

    public int ActionBy { get; set; }

    public DateTime ActionAt { get; set; }
}
