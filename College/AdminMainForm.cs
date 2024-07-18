using College.DAL.Reposetories;
using College.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class AdminMainForm : MiddleForm
    {
        CourseCycleRepository CourseCycleRepository = new CourseCycleRepository();
        StudentRepository StudentRepository = new StudentRepository();
        TeacherRepository TeacherRepository = new TeacherRepository();
        CourseRepository CourseRepository = new CourseRepository();

        public AdminMainForm(FormHandler formHandler) : base(formHandler, FormName.AdminMain)
        {
            InitializeComponent();
            LoadCoursesCyclesTable();
            LoadCoursesTable();
            LoadTeachers();
            LoadStudents();
        }

        private void LoadCoursesTable()
        {
            dataGridView_Courses.DataSource =  CourseRepository.GetAll();
        }

        private void LoadStudents()
        {
            dataGridView_students.DataSource = StudentRepository.GetAll();
        }

        private void LoadTeachers()
        {
            dataGridView_teachers.DataSource = TeacherRepository.GetAll();
        }

        private void LoadCoursesCyclesTable()
        {
            dataGridView_coursesCycles.DataSource = CourseCycleRepository.GetAll();
        }

        private void button_addCourseCycle_Click(object sender, EventArgs e)
        {

        }

        private void button_addCourse_Click(object sender, EventArgs e)
        {

        }
    }
}
