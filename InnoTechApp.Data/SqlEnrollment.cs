using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InnoTechApp.Core;
using Microsoft.EntityFrameworkCore;

namespace InnoTechApp.Data
{
    public class SqlEnrollment : IEnrollmentRepo
    {
        private readonly InnoTechAppDbContext _context;

        public SqlEnrollment(InnoTechAppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Enrollment> Enrollments()
        {
            return _context.Enrollments
                .Include(en => en.Course)
                .Include(en => en.Student)
                .OrderBy(en => en.Date)
                .ToList();
        }
    }
}
