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
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public ActionResult Index() { 
            var model = _courseRepository.GetAllCourses();
            return View(model);
        }
    }
}
