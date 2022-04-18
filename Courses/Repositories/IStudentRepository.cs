using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        public int GetCountStudent();
    }
}
