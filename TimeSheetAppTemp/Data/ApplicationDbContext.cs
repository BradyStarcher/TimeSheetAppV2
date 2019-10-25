using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeSheetAppTemp.Models;

namespace TimeSheetAppTemp.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, String>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
