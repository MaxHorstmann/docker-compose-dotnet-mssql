using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;

namespace test.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
        	const string sql = "SELECT name FROM Customers";
        	
            var model = new string[] { "John", "Peter", "Laura" };
            return View(model);
        }        
    }
}