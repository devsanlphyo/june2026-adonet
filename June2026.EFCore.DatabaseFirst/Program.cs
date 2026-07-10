using June2026.AttendanceTrackingSystemDB.AppDbContextModels;

AppDbContext db = new AppDbContext();

//// CRUD => Read
//var users = db.TblUsers.ToList();
//foreach(var user in users)
//{
//    Console.WriteLine($"{user.Id}. Full Name: {user.FullName}, Password: {user.Password}");
//}

//// CRUD => Create Attendance
//void clockIn(TblUser user)
//{
//    TblAttendanceRecord record = new TblAttendanceRecord();
//    record.UserId = user.Id;
//    record.ClockIn = DateTime.Now;
//    record.Date = DateOnly.FromDateTime(DateTime.Now);
//    db.TblAttendanceRecords.Add(record);
//    db.SaveChanges();
//    Console.WriteLine("User clocked in");
//}

//void clockOut(TblUser user)
//{
//    DateOnly today = DateOnly.FromDateTime(DateTime.Now);
//    var todayRecord = db.TblAttendanceRecords.Where(record => record.Date == today).FirstOrDefault();
//    if(todayRecord is null)
//    {
//        Console.WriteLine("No clock in so you cannot clock out");
//        return;
//    }
//    todayRecord.ClockOut = DateTime.Now;
//    db.SaveChanges();
//    Console.WriteLine("User clocked out");
//}

//var user = db.TblUsers.Where(user => user.Id == 3).FirstOrDefault();
//if(user is null)
//{
//    Console.WriteLine("Not found user");
//    return;
//}
//clockIn(user);
//clockOut(user);

//// CRUD => Update
//var user = db.TblUsers.Where(user => user.Id == 3).FirstOrDefault();
//if(user is null)
//{
//    Console.WriteLine("User not found");
//    return;
//}

//Console.WriteLine($"Full Name: {user.FullName} will be changed to \"San Linn Phyo\"");
//user.FullName = "San Linn Phyo";
//db.SaveChanges();
//Console.WriteLine($"Full Name changed: {user.FullName}");

// CRUD => Delete
var user = db.TblUsers.Where(user => user.FullName == "San Linn Phyo").FirstOrDefault();
if(user is null)
{
    Console.WriteLine("User not found");
    return;
}
DateOnly today = DateOnly.FromDateTime(DateTime.Now);
var record = db.TblAttendanceRecords.Where(record => record.Date == today && record.UserId == user.Id).FirstOrDefault();
if(record is null)
{
    Console.Write($"{user.FullName} has not no attendance record for today");
    return;
}
Console.WriteLine($"ClockIn: {record.ClockIn}, ClockOut: {record.ClockOut}");
db.TblAttendanceRecords.Remove(record);
db.SaveChanges();
