using System;
using System.Collections.Generic;
using System.Text;
using InnoTechApp.Core;

namespace InnoTechApp.Data
{
    public interface IEnrollmentRepo
    {
        IEnumerable<Enrollment> Enrollments();
    }
}
