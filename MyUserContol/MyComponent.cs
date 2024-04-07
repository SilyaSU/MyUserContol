using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUserContol
{
    public partial class MyComponent : Component
    {

        private Label timeLabel;

        public MyComponent()
        {
            InitializeComponent();
        }

        public MyComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void AttachLabel(Label label)
        {
            timeLabel = label;
        }


        public void OnMyTick(object sender, EventArgs e)
        {
            if (timeLabel != null)
            {
                timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            }
           
        }
    }
}
