using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetCourseWithInstructor();
        IEnumerable<Course> GetAllByInclude();
        public int GetCountCourse();
    }
}
