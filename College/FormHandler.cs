using College.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class FormHandler
    {

        Dictionary<FormName, BaseForm> FormNamesForms = new Dictionary<FormName, BaseForm>();

        public FormHandler()
        {

            FormNamesForms.Add(FormName.Main,new MainForm(this));
            FormNamesForms.Add(FormName.LoginAdmin,new AdminLoginForm(this));
            FormNamesForms.Add(FormName.AdminMain,new AdminMainForm(this));

        }

        internal void Run()
        {
            FormNamesForms[FormName.Main].Show();
        }

        public void GoTo(FormName CurrformName , FormName goToForm)
        {
            HideAllForms();
            FormNamesForms[goToForm].Show(); 
        }

       

        private void HideAllForms()
        {
            foreach(Form form in FormNamesForms.Values) 
                form.Hide();
        }
        private void CloseAllFormNoExit()
        {
            foreach (BaseForm form in FormNamesForms.Values)
                form.CloseWithoutExit();
        }

    }
}
