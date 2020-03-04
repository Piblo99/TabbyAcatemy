using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabbyAcatemy.Models
{
    public interface ICourseRepository
    {
        Course GetCourse(int Id);
        IEnumerable<Course> GetAllCourses();
        Course Add(Course course);
        Course Update(Course CourseChanges);
        Course Delete(int id);
    }
}
