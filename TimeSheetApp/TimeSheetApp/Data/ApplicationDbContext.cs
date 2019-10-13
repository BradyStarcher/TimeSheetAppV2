using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeSheetApp.Models;

namespace TimeSheetApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TimeSheetApp.Models.Division> Division { get; set; }
        public DbSet<TimeSheetApp.Models.Payroll> Payroll { get; set; }
        public DbSet<TimeSheetApp.Models.TimeClock> TimeClock { get; set; }
    }
}
