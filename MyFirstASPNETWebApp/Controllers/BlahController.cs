using Microsoft.AspNetCore.Mvc;
using MyFirstASPNETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View(); /*if this is Empty, it defaults to the view that shares the name with the above line (in this case, Index)*/
        }

        [HttpGet("GradeCalc")] // Attribute attached to the method below
        public IActionResult GradeCalc()
        {
            return View();
        }

        [HttpPost("GradeCalc")]
        public IActionResult GradeCalc (GradeCalcModel model)
        {
            return View();
        }
    }
}
