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
    public abstract partial class BaseForm : Form
    {
        protected bool IsNavigating = false;
        protected FormHandler _formHandler;
        protected FormName _formName;
        public BaseForm(FormHandler formHandler, FormName formName)
        {
            _formHandler = formHandler;
            _formName = formName;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public BaseForm() { }
        public void CloseWithoutExit()
        {
            IsNavigating = true;
            this.Close();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsNavigating)
                Application.Exit();
        }
    }
}
