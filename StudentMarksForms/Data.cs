using StudentMarks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarksForms
{
    internal class Data
    {
        static Course[] courses = new Course[100];
        static int CourseCount = 0;

        static Student[] students = new Student[10000];

        public static void AddCourse(Course course)
        {
            courses[CourseCount++] = course;
        }
    }
}
