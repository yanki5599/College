namespace College
{
    partial class MainForm
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
            button_gotoLoginStud = new Button();
            button_gotoLoginAdmin = new Button();
            SuspendLayout();
            // 
            // button_gotoLoginStud
            // 
            button_gotoLoginStud.Location = new Point(656, 262);
            button_gotoLoginStud.Name = "button_gotoLoginStud";
            button_gotoLoginStud.Size = new Size(200, 49);
            button_gotoLoginStud.TabIndex = 0;
            button_gotoLoginStud.Text = "כניסת סטודנטים";
            button_gotoLoginStud.UseVisualStyleBackColor = true;
            button_gotoLoginStud.Click += button_gotoLoginStud_Click;
            // 
            // button_gotoLoginAdmin
            // 
            button_gotoLoginAdmin.Location = new Point(130, 262);
            button_gotoLoginAdmin.Name = "button_gotoLoginAdmin";
            button_gotoLoginAdmin.Size = new Size(200, 49);
            button_gotoLoginAdmin.TabIndex = 0;
            button_gotoLoginAdmin.Text = "מנהל";
            button_gotoLoginAdmin.UseVisualStyleBackColor = true;
            button_gotoLoginAdmin.Click += button_gotoLoginAdmin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 639);
            Controls.Add(button_gotoLoginAdmin);
            Controls.Add(button_gotoLoginStud);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button_gotoLoginStud;
        private Button button_gotoLoginAdmin;
    }
}