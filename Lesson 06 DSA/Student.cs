using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06_DSA
{
    public class Student
    {
        public int StudentNumber { get; set; }

        public string Name { get; set; }

        public string toString()
        {
            return "Student Number = " + StudentNumber + " ; Name = " + Name;
        }
    }
}
