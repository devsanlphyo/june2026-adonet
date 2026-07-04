//using Dapper;
//using Microsoft.Data.SqlClient;
//using System.Data;

//SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
//{
//    DataSource = ".",
//    InitialCatalog = "June2026Db",
//    UserID = "sa",
//    Password = "sasa@123",
//    TrustServerCertificate = true,
//};

//using (IDbConnection db = new SqlConnection(sb.ConnectionString))
//{
//    db.Open();
//    List<Student> students = db.Query<Student>("SELECT * FROM [dbo].[Tbl_Student];").ToList();
//    foreach (Student student in students)
//    {
//        Console.WriteLine($"{student.FirstName}'s Last Name: ${student.LastName}");
//    }
//}

using June2026.Dapper;

StudentDapperService sds = new StudentDapperService();

//sds.Read();
//sds.Create();
//sds.Update();
//sds.Delete();