using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TeacherService
    {
        public List<Teacher> teachers;
        public List<Teacher> GetTeacher()
        {
            return teachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void UpdateTeacher(Teacher teacher)
        {

        }
        public void Delete(int id)
        {

        }
      
    }
}
