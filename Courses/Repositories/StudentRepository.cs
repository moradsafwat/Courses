using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(CourseDbContext _db) : base (_db)
        {
        }

        int IStudentRepository.GetCountStudent()
        {
            return db.Students.Count();
        }
    }
}
