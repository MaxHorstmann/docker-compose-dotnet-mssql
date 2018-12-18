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

namespace test.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
        	const string connectionString = "Data Source=sql;Initial Catalog=test;User Id=sa;Password=Password!";

        	using (SqlConnection connection = new SqlConnection(connectionString))	
        	{
	            var model = connection.Query<string>("SELECT name FROM Customers");
	            return View(model);        	
            }
	    }   
    }
}