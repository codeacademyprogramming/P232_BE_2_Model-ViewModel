using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<Student> _studnets;
        public StudentController()
        {
            _studnets = new List<Student>
            {
                new Student{Id = 1,FullName = "Hikmet Abbasov",Point = 87},
                new Student{Id = 2,FullName = "Tofiq Abbasov",Point = 57},
                new Student{Id = 3,FullName = "Nermin Abbasova",Point = 87},
                new Student{Id = 4,FullName = "Abbas Abbasov",Point = 97},
            };
        }

        public ActionResult Index()
        {
            ViewBag.Students = _studnets;

            return View();
        }

        public ActionResult Detail(int id)
        {
            Student std = _studnets.Find(x => x.Id == id);
            ViewBag.Student = std;
            
            return View();
        }

        //public ActionResult Detail(int id,int point)
        //{
        //    //return Content("StudentId: "+id+" - StudentPoint: "+point);
        //    ViewData["Id"] = id;
        //    ViewBag.Id = 50;

        //    TempData["Id"] = id;

        //    //return View();
        //    return RedirectToAction("info");
        //}

        //public ActionResult Info()
        //{
        //    return View();
        //}
    }
}
