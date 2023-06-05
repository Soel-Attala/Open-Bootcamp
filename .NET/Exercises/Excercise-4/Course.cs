using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_4
{
    public class Course
    {

        public enum CourseLevel
        {
            Basic,
            Intermediate,
            Advanced
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public int Capacity { get; set; }
        public Student[]? Students { get; set; } = new Student[0];
        public string? Category { get; set; }
    }
}
