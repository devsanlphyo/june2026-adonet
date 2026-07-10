using System;
using System.Collections.Generic;

namespace June2026.EFCoreAssignmentDB.AppDbContextModels;

public partial class TblTb2Food
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }
}
