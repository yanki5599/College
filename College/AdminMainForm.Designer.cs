namespace College
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            courses = new TabPage();
            dataGridView1 = new DataGridView();
            thechers = new TabPage();
            dataGridView2 = new DataGridView();
            students = new TabPage();
            dataGridView3 = new DataGridView();
            button_addCourse = new Button();
            button_addTeacher = new Button();
            button_addStudent = new Button();
            tabControl1.SuspendLayout();
            courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            thechers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(courses);
            tabControl1.Controls.Add(thechers);
            tabControl1.Controls.Add(students);
            tabControl1.Location = new Point(12, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 577);
            tabControl1.TabIndex = 0;
            // 
            // courses
            // 
            courses.Controls.Add(button_addCourse);
            courses.Controls.Add(dataGridView1);
            courses.Location = new Point(4, 24);
            courses.Name = "courses";
            courses.Padding = new Padding(3);
            courses.Size = new Size(886, 549);
            courses.TabIndex = 0;
            courses.Text = "קורסים";
            courses.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(874, 445);
            dataGridView1.TabIndex = 0;
            // 
            // thechers
            // 
            thechers.Controls.Add(button_addTeacher);
            thechers.Controls.Add(dataGridView2);
            thechers.Location = new Point(4, 24);
            thechers.Name = "thechers";
            thechers.Padding = new Padding(3);
            thechers.Size = new Size(886, 549);
            thechers.TabIndex = 1;
            thechers.Text = "מרצים";
            thechers.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 94);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(874, 449);
            dataGridView2.TabIndex = 0;
            // 
            // students
            // 
            students.Controls.Add(button_addStudent);
            students.Controls.Add(dataGridView3);
            students.Location = new Point(4, 24);
            students.Name = "students";
            students.Padding = new Padding(3);
            students.Size = new Size(886, 549);
            students.TabIndex = 2;
            students.Text = "סטודנטים";
            students.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 94);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(874, 449);
            dataGridView3.TabIndex = 1;
            // 
            // button_addCourse
            // 
            button_addCourse.Location = new Point(681, 42);
            button_addCourse.Name = "button_addCourse";
            button_addCourse.Size = new Size(158, 33);
            button_addCourse.TabIndex = 1;
            button_addCourse.Text = "הוסף קורס";
            button_addCourse.UseVisualStyleBackColor = true;
            // 
            // button_addTeacher
            // 
            button_addTeacher.Location = new Point(701, 31);
            button_addTeacher.Name = "button_addTeacher";
            button_addTeacher.Size = new Size(135, 40);
            button_addTeacher.TabIndex = 1;
            button_addTeacher.Text = "הוסף מרצה";
            button_addTeacher.UseVisualStyleBackColor = true;
            // 
            // button_addStudent
            // 
            button_addStudent.Location = new Point(720, 41);
            button_addStudent.Name = "button_addStudent";
            button_addStudent.Size = new Size(131, 33);
            button_addStudent.TabIndex = 2;
            button_addStudent.Text = "הוסף סטודנט";
            button_addStudent.UseVisualStyleBackColor = true;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 635);
            Controls.Add(tabControl1);
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginForm";
            tabControl1.ResumeLayout(false);
            courses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            thechers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage courses;
        private DataGridView dataGridView1;
        private TabPage thechers;
        private DataGridView dataGridView2;
        private TabPage students;
        private DataGridView dataGridView3;
        private Button button_addCourse;
        private Button button_addTeacher;
        private Button button_addStudent;
    }
}