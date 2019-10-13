using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetApp.Models;

namespace TimeSheetApp.Service
{
    public class DivisionService : IDivisionService
    {
        private readonly List<Division> _divisions;

        public DivisionService()
        {
            _divisions = new List<Division>()
            {
                new Division() {ID = 1, Name = "Sales"}
            };
        }

        public Division GetById(int id)
        {
            return _divisions.Where(a => a.ID == id)
            .FirstOrDefault();
        }
    }
}
