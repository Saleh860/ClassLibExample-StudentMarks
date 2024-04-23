namespace StudentMarksForms
{
    partial class AddNewCourseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CourseName = new TextBox();
            CourseCode = new TextBox();
            AddCourse = new Button();
            label3 = new Label();
            Credits = new NumericUpDown();
            label4 = new Label();
            CourseList = new ComboBox();
            showCourses = new Button();
            ((System.ComponentModel.ISupportInitialize)Credits).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 50);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Course Code";
            // 
            // CourseName
            // 
            CourseName.Location = new Point(145, 48);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(237, 23);
            CourseName.TabIndex = 1;
            // 
            // CourseCode
            // 
            CourseCode.Location = new Point(145, 86);
            CourseCode.Name = "CourseCode";
            CourseCode.Size = new Size(237, 23);
            CourseCode.TabIndex = 2;
            // 
            // AddCourse
            // 
            AddCourse.Location = new Point(169, 237);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(75, 23);
            AddCourse.TabIndex = 5;
            AddCourse.Text = "Add Course";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 130);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Credits";
            // 
            // Credits
            // 
            Credits.Location = new Point(151, 128);
            Credits.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            Credits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Credits.Name = "Credits";
            Credits.Size = new Size(120, 23);
            Credits.TabIndex = 3;
            Credits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 176);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 4;
            label4.Text = "Prerequisites";
            // 
            // CourseList
            // 
            CourseList.FormattingEnabled = true;
            CourseList.Location = new Point(147, 173);
            CourseList.Name = "CourseList";
            CourseList.Size = new Size(235, 23);
            CourseList.TabIndex = 4;
            // 
            // showCourses
            // 
            showCourses.Location = new Point(319, 237);
            showCourses.Name = "showCourses";
            showCourses.Size = new Size(75, 23);
            showCourses.TabIndex = 7;
            showCourses.Text = "Show ...";
            showCourses.UseVisualStyleBackColor = true;
            showCourses.Click += showCourses_Click;
            // 
            // AddNewCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 279);
            Controls.Add(showCourses);
            Controls.Add(CourseList);
            Controls.Add(Credits);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AddCourse);
            Controls.Add(CourseCode);
            Controls.Add(CourseName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewCourseForm";
            Text = "Add New Course";
            ((System.ComponentModel.ISupportInitialize)Credits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CourseName;
        private TextBox CourseCode;
        private Button AddCourse;
        private Label label3;
        private NumericUpDown Credits;
        private Label label4;
        private ComboBox CourseList;
        private Button showCourses;
    }
}
