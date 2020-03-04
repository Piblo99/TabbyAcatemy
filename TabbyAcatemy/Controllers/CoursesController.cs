using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabbyAcatemy.Models;

namespace TabbyAcatemy.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult Index() { 
            //CatIdentityDbContext cs = new CatIdentityDbContext();
            //List<Course> MyCourse = cs.Courses.ToList(); TODO: IMPLEMENT REPOSITORY PATTERN TO GET THIS LIST AND DISPLAY COURSES
            return View();
        }
    }
}
