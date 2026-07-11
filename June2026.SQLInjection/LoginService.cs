using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace June2026.SQLInjection;
internal class LoginService
{
    private readonly SqlConnectionStringBuilder _sb = new SqlConnectionStringBuilder
    {
        DataSource = ".",
        InitialCatalog = "June2026Db",
        UserID = "sa",
        Password = "sasa@123",
        TrustServerCertificate = true
    };

    public void VulnerableLogin(string username, string password)
    {
        using IDbConnection db = new SqlConnection(_sb.ConnectionString);
        //string query = $"""
        //        SELECT * FROM Tbl_User 
        //        WHERE Username = '{username}' AND Password = '{password}';
        //        """;
        string query = $@"
                SELECT * FROM Tbl_User 
                WHERE Username = '{username}' AND Password = '{password}';
                ";
        var user = db.Query(query).FirstOrDefault();
        if (user != null)
        {
            Console.WriteLine("Login success");
            Console.WriteLine($"User: {user}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Login failed!");
            Console.WriteLine("");
        }
    }

    public void SecuredLogin(string username, string password)
    {
        using IDbConnection db = new SqlConnection(_sb.ConnectionString);
        //string query = """
        //        SELECT * FROM Tbl_User 
        //        WHERE Username = @Username AND Password = @Password;
        //        """;
        string query = @"
                SELECT * FROM Tbl_User 
                WHERE Username = @Username AND Password = @Password;
                ";
        var user = db.Query(query, new
        {
            Username = username,
            Password = password
        }).FirstOrDefault();

        if (user != null)
        {
            Console.WriteLine("Login successful");
            Console.WriteLine($"User: {user}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Login failed!\n");
            Console.WriteLine("");
        }
    }

}
