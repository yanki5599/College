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
    public partial class MainForm : MiddleForm // to allow designer
    {

        public MainForm(FormHandler formHandler) : base(formHandler, FormName.Main)
        {
            InitializeComponent();

        }

        private void button_gotoLoginStud_Click(object sender, EventArgs e)
        {
            _formHandler.GoTo(_formName, FormName.LoginStudent);
        }

        private void button_gotoLoginAdmin_Click(object sender, EventArgs e)
        {
            _formHandler.GoTo(_formName, FormName.LoginAdmin);
        }
    }
}
