using AutoMapper;
using Intergration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intergration.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IntergrationDB _db;
        private readonly IMapper _map;

        public CustomerController(ILogger<CustomerController> logger, IntergrationDB db, IMapper map)
        {
            _logger = logger;
            _db = db;
            _map = map;
        }

        public IActionResult Index()
        {
             var data = _db.CallComments.Include(x => x.Customer).ToList();
            CustomerListViewModel model = new CustomerListViewModel()
            {
                CallComments = data
            };
            return View(model);
        } 
    }
}
