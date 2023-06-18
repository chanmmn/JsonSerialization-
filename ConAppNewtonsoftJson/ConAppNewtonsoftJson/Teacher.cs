using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNewtonsoftJson
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int BirthYear { get; set; }
        public int Level { get; set; }
        public List<Course> Courses { get; set; }
    }
}
