using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;


namespace June2026.Dapper
{
    
    internal class Student
    {
        // studentId, firstName, lastName, gender, dateOfBirth, email, phone, city, major, gpa

        public int StudentID;
        public string FirstName;
        public string LastName;
        public string Gender;
        public DateTime DateOfBirth;
        public string Email;
        public string Phone;
        public string City;
        public string Major;
        public decimal GPA;
    }

    internal class StudentDapperService
    {
        private readonly SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
        {
            DataSource = ".",
            InitialCatalog = "June2026Db",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,
        };

        public void Read() {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                List<Student> students = db.Query<Student>("SELECT * FROM [dbo].[Students];").ToList();
                foreach (Student student in students)
                {
                    Console.WriteLine($"{student.FirstName}'s Last Name: {student.LastName}");
                }
            }
        }
        public void Create() {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int result = db.Execute("INSERT INTO [dbo].[Students] (StudentID, FirstName, LastName, Gender, DateOfBirth, Email, Phone, City, Major, GPA) VALUES(1, 'San Linn', 'Phyo', 'Male', '2002-12-4', 'devsanlphyo@gmail.com', '09256741222', 'Yangon', 'CS', 9.0)");
                Console.WriteLine($"Create: Effected Rows: {result}");
            }
        }
        public void Update() {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int result = db.Execute("UPDATE [dbo].[Students] SET FirstName='Yae Linn Naing';");
                Console.WriteLine($"Effected Rows: {result}");
            }
        }
        public void Delete() {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int result = db.Execute("DELETE FROM Students;");
                Console.WriteLine($"Delete: Effected Rows: {result}");
            }
        }
    }
}
