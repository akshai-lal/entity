using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo.Models
{
    public class Course
    {
        public int CourseId {  get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
