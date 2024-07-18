namespace College
{
    partial class AdminLoginForm
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
            label1 = new Label();
            textBox_id = new TextBox();
            button_login = new Button();
            label2 = new Label();
            textBox_pass = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(385, 100);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "מספר זהות";
            // 
            // textBox_id
            // 
            textBox_id.Font = new Font("Segoe UI", 12F);
            textBox_id.Location = new Point(340, 130);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(132, 29);
            textBox_id.TabIndex = 0;
            // 
            // button_login
            // 
            button_login.Location = new Point(340, 294);
            button_login.Name = "button_login";
            button_login.Size = new Size(132, 26);
            button_login.TabIndex = 2;
            button_login.Text = "כניסה";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(414, 187);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 0;
            label2.Text = "סיסמה";
            // 
            // textBox_pass
            // 
            textBox_pass.Font = new Font("Segoe UI", 12F);
            textBox_pass.Location = new Point(340, 217);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(132, 29);
            textBox_pass.TabIndex = 1;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(textBox_pass);
            Controls.Add(label2);
            Controls.Add(textBox_id);
            Controls.Add(label1);
            Name = "AdminLoginForm";
            Text = "AdminLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_id;
        private Button button_login;
        private Label label2;
        private TextBox textBox_pass;
    }
}