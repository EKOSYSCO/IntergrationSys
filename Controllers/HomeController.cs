using AutoMapper;
using Intergration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intergration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IntergrationDB _db;
        private readonly IMapper _map;

        public HomeController(ILogger<HomeController> logger, IntergrationDB db, IMapper map)
        {
            _logger = logger;
            _db = db;
            _map = map;
        }

        public IActionResult Index(string code)
        {
            ViewBag.Code = code;
            return View(Search(code));
        }
        public CustomerDataViewModel Search(string code)
        {
            string connectionString =
                "data source=196.221.38.200,1976;Initial Catalog=MPLDATA_NEW;user id=sa;password=P@ssw0rd20102002";
            //data source = 192.168.1.5,1994; Initial Catalog = Wagon2022New; user id = sa; password = P@ssw0rd;

            // Provide the query string with a parameter placeholder.
            string queryString =
                $"exec [KO_SHREQDETM_CC] '{code}'";

            // Specify the parameter value.
            //   int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);


                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                CustomerDataViewModel cd = new CustomerDataViewModel();
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        cd.docid = reader["docid"].ToString();
                        cd.custname = reader["custname"].ToString();
                        cd.custage = (int)reader["custage"];
                        cd.comment = reader["comment"].ToString();
                        cd.sex = reader["sex"].ToString();
                        cd.custmob = reader["custmob"].ToString();
                        cd.custtel = reader["custtel"].ToString();
                        cd.agemeza = reader["agemeza"].ToString();
                        cd.ename = reader["ename"].ToString();
                        cd.custadd = reader["custadd"].ToString();
                        cd.doctorname = reader["doctorname"].ToString();


                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return cd;
            }
        }
        public IActionResult Update(CustomerDataViewModel model)
        {
            Customer dbCust = _db.Customers.FirstOrDefault(x => x.Code == model.ename);

            var item = _map.Map<Customer>(model);
            if (dbCust ==null )
            {
                _db.Customers.Add(item);
            }


            _db.CallComments.Add(new CallComment
            {
                Comment = model.CallComment,
                CustomerId = dbCust == null ? item.Id : dbCust.Id,
                CallDate = DateTime.Now,
                CreatedBy = "1"
            });



            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
