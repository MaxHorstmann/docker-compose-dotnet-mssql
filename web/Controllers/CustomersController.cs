using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using test;

namespace test.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
        	using (SqlConnection connection = new SqlConnection(Config.ConnectionString))	
        	{
	            var model = connection.Query<string>("SELECT name FROM Customers");
	            return View(model);        	
            }
	    }   
    }
}