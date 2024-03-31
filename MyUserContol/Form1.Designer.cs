namespace MyUserContol
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new Button();
            btnShowDialog = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            txtPassword = new TextBox();
            passwordTextBox1 = new PasswordTextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(0, 172);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.Click += BtnOk_Click;
            // 
            // btnShowDialog
            // 
            btnShowDialog.Location = new Point(102, 172);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(93, 23);
            btnShowDialog.TabIndex = 1;
            btnShowDialog.Text = "ShowDialog";
            btnShowDialog.Click += BtnShowDialog_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(0, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(195, 23);
            txtPassword.TabIndex = 2;
            // 
            // passwordTextBox1
            // 
            passwordTextBox1.AutoSize = true;
            passwordTextBox1.LabelText = "Пароль";
            passwordTextBox1.Location = new Point(12, 12);
            passwordTextBox1.Name = "passwordTextBox1";
            passwordTextBox1.Password = "";
            passwordTextBox1.Size = new Size(171, 109);
            passwordTextBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordTextBox1);
            Controls.Add(txtPassword);
            Controls.Add(btnOk);
            Controls.Add(btnShowDialog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PasswordTextBox passwordTextBox1;
        private Button btnOk;
        private Button btnShowDialog;
        private PageSetupDialog pageSetupDialog1;
        private TextBox txtPassword;
    }
}
