using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class Payroll
    {
        public int ID { get; set; }

        public decimal Salary { get; set; }

        public User EmployeeID { get; set; }
    }
}
