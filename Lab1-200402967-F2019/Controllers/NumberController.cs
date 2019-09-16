using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab1_200402967_F2019.Controllers
{
    public class NumberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Addition(int x, int y)
        {
            return Ok("Result = " + (x + y).ToString());
        }

        public IActionResult Multiplication(int x, int y)
        {
            return Ok("Result = " + (x * y).ToString());
        }
    }
}