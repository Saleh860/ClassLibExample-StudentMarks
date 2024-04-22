using StudentMarks;

namespace StudentMarksForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course(CourseCode.Text, CourseName.Text, 3, null); ;
            Data.AddCourse(newCourse);
            CourseCode.Text = "";
            CourseName.Text = "";
            CourseName.Focus();
        }
    }
}
