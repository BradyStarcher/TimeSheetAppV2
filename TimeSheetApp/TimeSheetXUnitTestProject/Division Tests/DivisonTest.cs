using System;
using System.Collections.Generic;
using System.Text;
using TimeSheetApp.Models;
using TimeSheetApp.Data;
using TimeSheetApp.Service;
using TimeSheetApp.Controllers;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace TimeSheetXUnitTestProject.Division_Tests
{
    [Collection("Division Tests")]
    public class DivisonTest
    {
        private readonly ApplicationDbContext _db;
        private DivisionController _controller;

        public DivisonTest()
        {
            _db = new ApplicationDbContext();
            _controller = new DivisionController(_db);
        }

        [Fact]
        public void TestCreate()
        {
            var testDivision = new Division() { ID = 2, Name = "Floor Setting" };

            var create = _controller.Create(testDivision);
        }

        //[Fact]
        //public void Test()
        //{
        //    Assert.Equal(15, Add(5, 10));
        //}

        //int Add(int x, int y)
        //{
        //    return x + y;
        //}
    }
}
