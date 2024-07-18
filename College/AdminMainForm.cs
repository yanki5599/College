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

        public AdminMainForm(FormHandler formHandler): base(formHandler, FormName.AdminMain)
        {
            InitializeComponent();
            LoadCoursesTable();
            LoadTeachers();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridView3.DataSource = StudentsRepository.GetAll();
        }

        private void LoadTeachers()
        {
            dataGridView2.DataSource = TeachersRepository.GetAll();
        }

        private void LoadCoursesTable()
        {
            dataGridView1.DataSource = CourseCycleRepository.GetAll();
        }
    }
}
