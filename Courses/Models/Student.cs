using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
