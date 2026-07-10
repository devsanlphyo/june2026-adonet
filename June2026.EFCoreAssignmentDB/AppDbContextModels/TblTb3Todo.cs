using System;
using System.Collections.Generic;

namespace June2026.EFCoreAssignmentDB.AppDbContextModels;

public partial class TblTb3Todo
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public string? Description { get; set; }
}
