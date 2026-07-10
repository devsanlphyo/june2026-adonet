using System;
using System.Collections.Generic;

namespace June2026.EFCoreAssignmentDB.AppDbContextModels;

public partial class TblUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Bio { get; set; } = null!;
}
