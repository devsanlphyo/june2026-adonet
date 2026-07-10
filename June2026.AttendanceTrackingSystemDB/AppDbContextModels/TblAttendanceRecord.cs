using System;
using System.Collections.Generic;

namespace June2026.AttendanceTrackingSystemDB.AppDbContextModels;

public partial class TblAttendanceRecord
{
    public int Id { get; set; }

    public DateTime? ClockIn { get; set; }

    public DateTime? ClockOut { get; set; }

    public int UserId { get; set; }

    public DateOnly? Date { get; set; }

    public virtual TblUser User { get; set; } = null!;
}
