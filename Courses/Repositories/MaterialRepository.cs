using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        public MaterialRepository(CourseDbContext _db): base(_db)
        {
        }
        public IEnumerable<Material> GetCourseWithMaterial(int id)
        {

            return db.Materials.Where(c => c.CourseId == id).ToList();
            
            
            //(IEnumerable<Material>)data;

            //var CourseMaterial = db.Courses.Include("Material").SingleOrDefault(c => c.Id == id);
            //return (IEnumerable<Course>) CourseMaterial;
        }
    }
}
