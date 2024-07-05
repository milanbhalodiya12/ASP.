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
            ViewData["Country"] = new List<String>() {"India","Pakistan" };
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}