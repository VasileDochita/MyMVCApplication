using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    //public class StudentController : Controller
    //{
    //    // GET: Student
    //    public string Index() => "This is Index action method of StudentController";
    //}
    //public class StudentController : Controller
    //{
    //    public StudentController()
    //    {

    //    }

    //    [NonAction]
    //    public Student GetStudent(int id)
    //    {
    //        return studentList.Where(s => s.StudentId == id).FirstOrDefault();
    //    }
    //}
    public class StudentController : Controller
    {
        public StudentController()
        {

        }

        [ActionName("find")]
        public ActionResult GetById(int id)
        {
            // get student from the database 
            return View();
        }
    }
}