using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CourseService
    {
        public List<Course> courses;
         
        public CourseService()
        {
            courses = new List<Course>();
        }

        public List<Course> GetCourses()
        {
            return courses;
        }
        

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
       
        public void UpdateStudent(Course Course)
        {

        }
       
        public void Delete(int id)
        {

        }
    }
}
