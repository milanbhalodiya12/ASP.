using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //Student s = new Student();
            //s.Id = 1;
            //s.Name = "Milan Bhalodiya";
            //s.Desc = "Mca Student";

            List<Student> list = new List<Student>() {
            new Student() {
                    Id = 1,
                    Name = "Bhalodiya Milan D.",
                    City = "Morbi",
                    
            },
            new Student() {
                    Id = 2,
                    Name = "Masot Krusahl M",
                    City = "Morbi",
                    
            },
            new Student() {
                    Id = 3,
                    Name = "Khan Shaban S",
                    City = "Surat",
                   
            },
              new Student() {
                    Id = 4,
                    Name = "Makwana Vishal",
                    City = "Rajkot",
                   
            },
    };
            ViewBag.model = list;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.City = new List<String>() {"Los Angeles", "San Francisco","Whales","Oxford","Cambridge" };
            ViewData["Country"] = new List<String>() {"India","California","Venezula","Spain" };
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Calculator()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculator(double number1, double number2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "sum":
                    result = number1 + number2;
                    break;
                case "subtract":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                case "divide":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        // Handle division by zero error
                        ViewBag.Error = "Cannot divide by zero.";
                    }
                    break;
            }

            ViewBag.Result = result;
            return View("Calculator");
        }

    }

}
