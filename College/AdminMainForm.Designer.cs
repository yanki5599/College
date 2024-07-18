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
            coursesCycles = new TabPage();
            button_addCourseCycle = new Button();
            dataGridView_coursesCycles = new DataGridView();
            thechers = new TabPage();
            button_addTeacher = new Button();
            dataGridView_teachers = new DataGridView();
            students = new TabPage();
            button_addStudent = new Button();
            dataGridView_students = new DataGridView();
            Courses = new TabPage();
            dataGridView_Courses = new DataGridView();
            button_addCourse = new Button();
            tabControl1.SuspendLayout();
            coursesCycles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_coursesCycles).BeginInit();
            thechers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_teachers).BeginInit();
            students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_students).BeginInit();
            Courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Courses).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(coursesCycles);
            tabControl1.Controls.Add(thechers);
            tabControl1.Controls.Add(students);
            tabControl1.Controls.Add(Courses);
            tabControl1.Location = new Point(12, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 577);
            tabControl1.TabIndex = 0;
            // 
            // coursesCycles
            // 
            coursesCycles.Controls.Add(button_addCourseCycle);
            coursesCycles.Controls.Add(dataGridView_coursesCycles);
            coursesCycles.Location = new Point(4, 24);
            coursesCycles.Name = "coursesCycles";
            coursesCycles.Padding = new Padding(3);
            coursesCycles.Size = new Size(886, 549);
            coursesCycles.TabIndex = 0;
            coursesCycles.Text = "קורסים";
            coursesCycles.UseVisualStyleBackColor = true;
            // 
            // button_addCourseCycle
            // 
            button_addCourseCycle.Location = new Point(681, 42);
            button_addCourseCycle.Name = "button_addCourseCycle";
            button_addCourseCycle.Size = new Size(158, 33);
            button_addCourseCycle.TabIndex = 1;
            button_addCourseCycle.Text = "הוסף קורס";
            button_addCourseCycle.UseVisualStyleBackColor = true;
            button_addCourseCycle.Click += button_addCourseCycle_Click;
            // 
            // dataGridView_coursesCycles
            // 
            dataGridView_coursesCycles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_coursesCycles.Location = new Point(6, 98);
            dataGridView_coursesCycles.Name = "dataGridView_coursesCycles";
            dataGridView_coursesCycles.Size = new Size(874, 445);
            dataGridView_coursesCycles.TabIndex = 0;
            // 
            // thechers
            // 
            thechers.Controls.Add(button_addTeacher);
            thechers.Controls.Add(dataGridView_teachers);
            thechers.Location = new Point(4, 24);
            thechers.Name = "thechers";
            thechers.Padding = new Padding(3);
            thechers.Size = new Size(886, 549);
            thechers.TabIndex = 1;
            thechers.Text = "מרצים";
            thechers.UseVisualStyleBackColor = true;
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
            // dataGridView_teachers
            // 
            dataGridView_teachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_teachers.Location = new Point(6, 94);
            dataGridView_teachers.Name = "dataGridView_teachers";
            dataGridView_teachers.Size = new Size(874, 449);
            dataGridView_teachers.TabIndex = 0;
            // 
            // students
            // 
            students.Controls.Add(button_addStudent);
            students.Controls.Add(dataGridView_students);
            students.Location = new Point(4, 24);
            students.Name = "students";
            students.Padding = new Padding(3);
            students.Size = new Size(886, 549);
            students.TabIndex = 2;
            students.Text = "סטודנטים";
            students.UseVisualStyleBackColor = true;
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
            // dataGridView_students
            // 
            dataGridView_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_students.Location = new Point(6, 94);
            dataGridView_students.Name = "dataGridView_students";
            dataGridView_students.Size = new Size(874, 449);
            dataGridView_students.TabIndex = 1;
            // 
            // Courses
            // 
            Courses.Controls.Add(dataGridView_Courses);
            Courses.Controls.Add(button_addCourse);
            Courses.Location = new Point(4, 24);
            Courses.Name = "Courses";
            Courses.Padding = new Padding(3);
            Courses.Size = new Size(886, 549);
            Courses.TabIndex = 3;
            Courses.Text = "סוגי קורסים";
            Courses.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Courses
            // 
            dataGridView_Courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Courses.Location = new Point(9, 97);
            dataGridView_Courses.Name = "dataGridView_Courses";
            dataGridView_Courses.Size = new Size(874, 449);
            dataGridView_Courses.TabIndex = 3;
            // 
            // button_addCourse
            // 
            button_addCourse.Location = new Point(701, 47);
            button_addCourse.Name = "button_addCourse";
            button_addCourse.Size = new Size(158, 33);
            button_addCourse.TabIndex = 2;
            button_addCourse.Text = "הוסף קורס";
            button_addCourse.UseVisualStyleBackColor = true;
            button_addCourse.Click += button_addCourse_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 635);
            Controls.Add(tabControl1);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginForm";
            tabControl1.ResumeLayout(false);
            coursesCycles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_coursesCycles).EndInit();
            thechers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_teachers).EndInit();
            students.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_students).EndInit();
            Courses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Courses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage coursesCycles;
        private DataGridView dataGridView_coursesCycles;
        private TabPage thechers;
        private DataGridView dataGridView_teachers;
        private TabPage students;
        private DataGridView dataGridView_students;
        private Button button_addCourseCycle;
        private Button button_addTeacher;
        private Button button_addStudent;
        private TabPage Courses;
        private Button button_addCourse;
        private DataGridView dataGridView_Courses;
    }
}