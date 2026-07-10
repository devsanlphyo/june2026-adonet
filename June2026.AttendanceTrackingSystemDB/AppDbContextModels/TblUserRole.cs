using System;
using System.Collections.Generic;

namespace June2026.AttendanceTrackingSystemDB.AppDbContextModels;

public partial class TblUserRole
{
    public int Id { get; set; }

    public string Role { get; set; } = null!;

    public virtual ICollection<TblUser> TblUsers { get; set; } = new List<TblUser>();
}
