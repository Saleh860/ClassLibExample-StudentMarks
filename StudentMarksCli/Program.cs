// See https://aka.ms/new-console-template for more information
using StudentMarks;

Console.WriteLine("Hello, World!");

Course Programming = new Course("803100", "Programming", 3, null);
Course Programming2 = new Course("803200", "Programming II", 3, Programming);
Course Circuits = new Course("803101", "Electric Circuits", 3, null);

Student Ahmed = new Student("Ahmed Mohamed", 1234567);
Student Yahya = new Student("Yahya Mohamed", 1234000);

int Semester = 451;
Ahmed.AddEnrollment(new Enrollment(Circuits, Semester));
Ahmed.AddEnrollment(new Enrollment(Programming,Semester));
Yahya.AddEnrollment(new Enrollment(Programming, Semester));

Semester = 452;
Ahmed.AddEnrollment(new Enrollment(Programming2, Semester));
Yahya.AddEnrollment(new Enrollment(Programming2, Semester));
Yahya.AddEnrollment(new Enrollment(Circuits, Semester));


Console.WriteLine("Ahmed's Enrollments in 1st Semester");
WriteEnrollments(Ahmed.GetEnrollments(451));
Console.WriteLine("Yahya's Enrollments in 2nd Semester");
WriteEnrollments(Yahya.GetEnrollments(452));

void WriteEnrollments(Enrollment[] enrollments)
{
    for(int i = 0; i < enrollments.Length; i++)
    {
        Console.WriteLine(enrollments[i].Course.Name);
    }
}


