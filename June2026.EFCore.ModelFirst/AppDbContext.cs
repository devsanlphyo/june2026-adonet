using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2026.EFCore.ModelFirst;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder
            {
                DataSource = ".",
                InitialCatalog = "June2026Db",
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true,
            };
            optionsBuilder.UseSqlServer(sb.ConnectionString);
        }
    }
    public DbSet<UserEntity> Users { get; set; }
}

