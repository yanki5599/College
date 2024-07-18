using College.DAL.Reposetories;
using College.Enum;
using College.Model;
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
    public partial class AdminLoginForm : MiddleForm
    {
        AdminUserRepository AdminUserRepository = new AdminUserRepository();
        public AdminLoginForm(FormHandler formHandler) : base(formHandler, FormName.LoginAdmin)
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (ValidateInfo(out AdminUser? empInfo))
            {
               _formHandler.GoTo(_formName,FormName.AdminMain);
            }
        }

        private bool ValidateInfo(out AdminUser? AdminUser)
        {
            // get id from form

            string idStr = textBox_id.Text.Trim();
            bool valid = Utils.isValidNatId(idStr);
            if (!valid)
            {
                MessageBox.Show("הכנס מס' זהות תקין.", "שגיאת פורמט", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdminUser = null;
                return false;
            }

            //check if exist in db
            valid = AdminUserRepository.IsUserExist(idStr, out AdminUser? AdminUser1);
            if (!valid)
            {
                MessageBox.Show("משתמש לא נמצא!", "לא נמצא", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                AdminUser = null;
                textBox_id.Text = null; // reset field
                return false;
            }

            //get pass from form
            string password = textBox_pass.Text.Trim();
            valid = AdminUserRepository.ValidateUserPass(AdminUser1, password);
            if (!valid)
            {
                MessageBox.Show("סיסמה שגויה!", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdminUser = null;
                textBox_pass.Text = null; // reset field
                return false;
            }

            AdminUser = AdminUser1;
            return true;
        }
    }
}
