using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyUserContol
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private void BtnShowDialog_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            DialogResult result = myForm.ShowDialog();
            MessageBox.Show("Результат диалога: " + result.ToString());
            if (result == DialogResult.OK)
            {
                string password = myForm.Password;
                passwordTextBox1.Password = password;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
