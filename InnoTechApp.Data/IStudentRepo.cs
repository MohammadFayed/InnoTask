using System;
using System.Collections.Generic;
using System.Text;
using InnoTechApp.Core;

namespace InnoTechApp.Data
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
    }
}
