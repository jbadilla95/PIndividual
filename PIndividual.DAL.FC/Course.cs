using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIndividual.DAL.FC
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }

        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
