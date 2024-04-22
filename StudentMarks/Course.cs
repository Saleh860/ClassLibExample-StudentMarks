using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    public class Course
    {
        public string Code { get; }
        public string Name { get; }
        public int Credits { get; }
        public Course Prerequisite { get; }

        public Course(string code, string name, 
            int credits, Course prerequisite)
        {
            Code = code;
            Name = name;
            Credits = credits;
            Prerequisite = prerequisite;
        }
    }
}
