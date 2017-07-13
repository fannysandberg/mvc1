using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcGrupparbete.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcGrupparbete.Controllers
{
    public class BandsController : Controller
    {
        public IActionResult Details(int id)
        {
            var band = DataManager.GetBandById(id);
            return View(band);
        }

        public IActionResult Index()
        {
            var band = DataManager.GetAllBands();
            return View(band);
        }
    }
}
