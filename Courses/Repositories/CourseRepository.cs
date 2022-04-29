using Courses.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(CourseDbContext _db):base(_db)
        {
        }

        public IEnumerable<Course> GetAllByInclude()
        {
            return db.Courses.Include("Instructor").ToList();

//             (IEnumerable< Course>) course;
        }

        public int GetCountCourse()
        {
            return db.Courses.Count();
        }

        public IEnumerable<Course> GetCourseWithInstructor()
        {
            var course = db.Courses
                .Join(
                db.Instructors,
                course => course.InstructorId,
                instructor => instructor.Id,
                (course, instructor) => new
                {
                    CourseId = course.Id,
                    CourseTitle = course.Title,
                    CourseDescription = course.Description,
                    InstructorName = instructor.Name
                }).ToList();
            return (IEnumerable<Course>)course;
        }

        
    }
}
