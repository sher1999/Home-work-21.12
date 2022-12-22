using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infrastructure.Services
{
    public class StudentService
    {
        public List<Student> students;

        public StudentService()
        {
            students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void UpdateStudent(Student student, int id)
        {    // Two
            
            // One 
            var find = students.FirstOrDefault(x => x.Id == id);
            find.FirstName = student.FirstName;
            find.LastName = student.LastName;
            find.Address = student.Address;


        }
        public void Delete(int id)
        {

        }
    }
}
