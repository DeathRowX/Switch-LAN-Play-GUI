using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Switch_LAN_Play_GUI.Custom_Controls
{
    public partial class ServerListing : UserControl
    {
        public ServerListing()
        {
            InitializeComponent();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Aqua;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.LightCoral;
        }
    }
}
