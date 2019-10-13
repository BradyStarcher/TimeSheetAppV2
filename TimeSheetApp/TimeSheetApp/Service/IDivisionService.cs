using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheetApp.Models;

namespace TimeSheetApp.Service
{
    public interface IDivisionService
    {
        Division GetById(int id);
    }
}
