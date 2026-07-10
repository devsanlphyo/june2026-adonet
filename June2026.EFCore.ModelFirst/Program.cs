using June2026.EFCore.ModelFirst;
using Microsoft.EntityFrameworkCore.Design.Internal;

AppDbContext db = new AppDbContext();

//// CRUD => Read
//List<UserEntity> users = db.Users.ToList();
//foreach (UserEntity user in users)
//{
//    Console.WriteLine($"{user.UserId}. Username: {user.Username}, Password: {user.Password}");
//}

// CRUD => Update
//UserEntity? user = db.Users.Where(user => user.UserId == 3).FirstOrDefault();
//if(user is null)
//{
//    Console.WriteLine("No user found!");
//    return;
//}
//user.Username = "Drake";
//int affectedRowCounts = db.SaveChanges();
//Console.WriteLine($"Affected row counts: {affectedRowCounts}");

//// CRUD => Create
//UserEntity user = new UserEntity() { Username = "Post Malone", Password = "123", Bio = "Singer" };
//db.Users.Add(user);
//int affectedRowCounts = db.SaveChanges();
//Console.WriteLine($"Affected row counts: {affectedRowCounts}");

// CRUD => Delete
UserEntity? user = db.Users.Where(user => user.UserId == 5).FirstOrDefault();
if(user is null)
{
    Console.WriteLine("User not found!");
    return;
}
db.Users.Remove(user);
int affectedRowCounts = db.SaveChanges();
Console.WriteLine($"Affected row counts: {affectedRowCounts}");

Console.WriteLine("Press Enter to exist");
Console.ReadLine();
