namespace StudentMarks
{
    public class Student
    {
        string Name;
        long Id;

        Enrollment[] Enrollments;
        int EnrollmentCount;
        const int MaxEnrollmentCount = 100;

        public Student(string name, long id)
        {
            this.Name = name;
            this.Id = id;
            EnrollmentCount = 0;
            Enrollments = new Enrollment[MaxEnrollmentCount];
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            bool canEnroll = true;
            if(enrollment.Course.Prerequisite!=null)
            {
                canEnroll = false;
                for(int i=0; i<EnrollmentCount; i++)
                {
                    if (Enrollments[i].Course == enrollment.Course.Prerequisite 
                        && Enrollments[i].Mark>=60)
                        canEnroll = true;
                }
            }
            if(canEnroll)
            {
                Enrollments[EnrollmentCount++] = enrollment;
            }
        }

        public Enrollment[] GetEnrollments(int Semester)
        {
            int Count = 0;
            for(int i = 0;i<EnrollmentCount;i++)
            {
                if (Enrollments[i].Semester == Semester)
                {
                    Count++;
                }
            }
            Enrollment[] SemesterEnrollments = 
                new Enrollment[Count];
            Count= 0;
            for (int i = 0; i < EnrollmentCount; i++)
            {
                if (Enrollments[i].Semester == Semester)
                {
                    SemesterEnrollments[Count++]= Enrollments[i];
                }
            }
            return SemesterEnrollments;
        }
    }
}
