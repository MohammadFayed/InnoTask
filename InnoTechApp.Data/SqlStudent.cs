using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InnoTechApp.Core;

namespace InnoTechApp.Data
{
    public class SqlStudent : IStudentRepo
    {
        private readonly InnoTechAppDbContext _context;

        public SqlStudent(InnoTechAppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.StudentId == id);
        }
    }
}
