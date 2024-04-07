using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyUserContol
{
    public partial class MainForm : Form
    {

        public int totalRecords = 0;
        public int totalAge = 0;

        public MainForm()
        {
            InitializeComponent();

            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PersonRecordUserControl person = new PersonRecordUserControl();

            flowLayoutPanel.Controls.Add(person);

            totalRecords++;

            AllRecordsTextBox.Text = totalRecords.ToString();
        }



    }
}
