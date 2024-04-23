using StudentMarks;

namespace StudentMarksForms
{
    public partial class AddNewCourseForm : Form
    {
        public AddNewCourseForm()
        {
            InitializeComponent();
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            Course prerequisite = Data.GetCourse(CourseList.SelectedIndex);
            Course newCourse = new Course(CourseCode.Text,
                CourseName.Text, Convert.ToInt32(Credits.Value), prerequisite);
            Data.AddCourse(newCourse);
            FillPrerequisitesList();
            CourseCode.Text = "";
            CourseName.Text = "";
            CourseName.Focus();
        }
        private void FillPrerequisitesList()
        {
            CourseList.Items.Clear();
            for (int i = 0; i < Data.GetCourseCount(); i++)
            {
                CourseList.Items.Add(Data.GetCourse(i).Name);
            }
        }

        private void showCourses_Click(object sender, EventArgs e)
        {
            new ShowCourseListForm().ShowDialog();
        }
    }
}
