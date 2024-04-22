using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks
{
    public class Enrollment
    {
        public int Semester { get; }
        public Course Course { get; }
        public double Mark {
            get { return Mark; }
            set {
                if (value < 0 || value > 100) 
                    throw new FormatException();
        } }
        public string Grade { get {
                if (Mark < 60) return "F";
                if (Mark < 65) return "D";
                if (Mark < 70) return "D+";
                if (Mark < 75) return "C";
                if (Mark < 80) return "C+";
                if (Mark < 85) return "B";
                if (Mark < 90) return "B+";
                if (Mark < 95) return "A";
                return "A+";
            }
        }

        public Enrollment(Course course, int Semester)
        {
            this.Course = course;
            this.Semester = Semester;
            this.Mark = 0;
        }
    }
}
