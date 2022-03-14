using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string NameCourse { get; set; }
        public string Type { get; set; }
        public string VideoLink { get; set; }
        public string Conten { get; set; }
        public string FilePath { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
