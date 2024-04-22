namespace StudentMarksForms
{
    partial class Form1
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
            CourseName.TabIndex = 2;
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
            AddCourse.Location = new Point(169, 149);
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(75, 23);
            AddCourse.TabIndex = 3;
            AddCourse.Text = "Add Course";
            AddCourse.UseVisualStyleBackColor = true;
            AddCourse.Click += AddCourse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddCourse);
            Controls.Add(CourseCode);
            Controls.Add(CourseName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CourseName;
        private TextBox CourseCode;
        private Button AddCourse;
    }
}
