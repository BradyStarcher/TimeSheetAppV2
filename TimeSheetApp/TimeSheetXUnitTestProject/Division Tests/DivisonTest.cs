﻿using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetApp.Models;
using TimeSheetApp.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TimeSheetXUnitTestProject.Division_Tests
{
    class DivisonTest : IDisposable
    {
        private readonly ApplicationDbContext _db;

        public DivisonTest()
        {
            _db = new ApplicationDbContext();
        }

        public void Dispose()
        {
            //_db.Dispose();
        }


    }
}