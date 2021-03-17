using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Switch_LAN_Play_GUI
{
    public partial class WindowMain : Form
    {
        public WindowMain()
        {
            InitializeComponent();

            Log.windowMain = this;

            Log.Output("This is a message without a prefix");
            Log.Output("[DEBUG]: This is a normal message");
            Log.Output("[ERROR]: This is an error message");
            Log.Output("[APPLICATION]: This is a message from the application");
        }
    }
}
