using _0306191373_0306191333_0306191376_0306191482.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _0306191373_0306191333_0306191376_0306191482.Data;

namespace _0306191373_0306191333_0306191376_0306191482.Controllers
{
    public class HomeController : Controller
    {   //tiendv
        private readonly ShopContext _context;
        //tiendv
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ShopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async  Task<IActionResult> Index()
        {
            //tiendv
            return View(await _context.Products.ToListAsync());
            //tiendv
           // return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
