using CopyLogs.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopyLogs
{
    public class BeeOfficeContext : DbContext
    {
        public DbSet<AppError> AppErrors { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=.\MSSQLDEV;Database=BeeOffice;Trusted_Connection=True;");
        }
    }
}
