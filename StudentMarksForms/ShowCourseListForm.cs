using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarksForms
{
    public partial class ShowCourseListForm : Form
    {
        public ShowCourseListForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for(int i=0; i<Data.GetCourseCount(); i++)
            {
                ListViewItem item= new ListViewItem();
                item.Text = Data.GetCourse(i).Code;
                item.SubItems.Add(Data.GetCourse(i).Name);
                item.SubItems.Add($"{Data.GetCourse(i).Credits}");
                if(Data.GetCourse(i).Prerequisite!= null)
                    item.SubItems.Add(Data.GetCourse(i).Prerequisite.Name);

                listView1.Items.Add(item);
            }
        }
    }
}
