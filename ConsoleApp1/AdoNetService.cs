using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingNameSpace
{
    internal class AdoNetService
    {
        public void Read()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026Db";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);

            connection.Open();

            string query = @"
              SELECT TOP (1000) [StudentID]
                  ,[FirstName]
                  ,[LastName]
                  ,[Gender]
                  ,[DateOfBirth]
                  ,[Email]
                  ,[Phone]
                  ,[City]
                  ,[Major]
                  ,[GPA]
              FROM [June2026Db].[dbo].[Students]
            ";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["FirstName"]);
                Console.WriteLine(dr["FirstName"]);
            }

            connection.Close();
        }

        public void Create() {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026Db";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);

            connection.Open();

            string query = @"
             INSERT INTO Students
(StudentID, FirstName, LastName, Gender, DateOfBirth, Email, Phone, City, Major, GPA)
VALUES
(11, 'Ethan', 'Clark', 'Male', '2002-10-14', 'ethan.clark@email.com', '0955566677', 'Yangon', 'Software Engineering', 3.72);
";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Update()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026Db";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);

            connection.Open();

            string query = @"
             UPDATE Students
SET
    FirstName = 'Nicolas',
    LastName = 'Davis',
    Gender = 'Female',
    DateOfBirth = '2002-11-05',
    Email = 'sophia.davis@email.com',
    Phone = '0945678901',
    City = 'Bago',
    Major = 'Accounting',
    GPA = 3.65
WHERE StudentID = 4;
";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026Db";
            sb.UserID = "sa";
            sb.Password = "sasa@123";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);

            connection.Open();

            string query = @"
              DELETE FROM [June2026Db].[dbo].[Students]
";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
