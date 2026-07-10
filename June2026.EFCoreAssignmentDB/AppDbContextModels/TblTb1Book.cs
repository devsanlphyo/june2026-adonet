using System;
using System.Collections.Generic;

namespace June2026.EFCoreAssignmentDB.AppDbContextModels;

public partial class TblTb1Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Author { get; set; } = null!;
}
