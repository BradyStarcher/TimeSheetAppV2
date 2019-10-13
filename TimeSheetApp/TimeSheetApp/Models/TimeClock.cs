using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class TimeClock
    {
        public int ID { get; set; }

        public DateTime ClockIn { get; set; }

        public DateTime InLunch { get; set; }

        public DateTime OutLunch { get; set; }

        public DateTime ClockOut { get; set; }

        public User EmployeeID { get; set; }
    }
}
