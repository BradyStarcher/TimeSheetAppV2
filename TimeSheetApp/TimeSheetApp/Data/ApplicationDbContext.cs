using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeSheetApp.Models;

namespace TimeSheetApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        private string connectionString = @"Server=localhost\SQLEXPRESS;database=TimeSheetApp;MultipleActiveResultSets=true;Trusted_Connection=True;";

        public DbSet<TimeSheetApp.Models.Division> Division { get; set; }
        public DbSet<TimeSheetApp.Models.Payroll> Payroll { get; set; }
        public DbSet<TimeSheetApp.Models.TimeClock> TimeClock { get; set; }
    }
}
