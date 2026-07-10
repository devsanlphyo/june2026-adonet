using System;
using System.Collections.Generic;

namespace June2026.AttendanceTrackingSystemDB.AppDbContextModels;

public partial class TblUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Bio { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual TblUserRole Role { get; set; } = null!;

    public virtual ICollection<TblAttendanceRecord> TblAttendanceRecords { get; set; } = new List<TblAttendanceRecord>();
}
