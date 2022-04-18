using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(CourseDbContext _db):base(_db)
        {
        }
        public int GetCountInstructor()
        {
            return db.Instructors.Count();
        }

    }
}
