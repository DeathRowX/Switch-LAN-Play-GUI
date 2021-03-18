using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Switch_LAN_Play_GUI
{
    public partial class WindowMain : Form
    {
        public static string fileServerListName = "servers.json";
        public static string fileSettingsName = "settings.json";
        public static string fileLogConsoleName = "log_console.txt";
        public static string fileLogErrorName = "log_error.txt";

        public WindowMain()
        {
            InitializeComponent();

            Log.windowMain = this;
            Servers.windowMain = this;

            lVersion.Text = $"Version {Version.Get()}";

            // DEGUB -->
            Log.Output("This is a message without a prefix");
            Log.Output("[DEBUG]: This is a normal message");
            Log.Output("[ERROR]: This is an error message");
            Log.Output("[APPLICATION]: This is a message from the application");

            Servers.List = JsonConvert.DeserializeObject<List<Server>>(File.ImportText(fileServerListName));
            //File.ExportJson("Test.json", Servers.List);
            // <-- DEBUG

            Servers.PopulateList();
        }

        private void bLogsClear_Click(object sender, EventArgs e)
        {
            Log.Clear();
        }

        private void bLogsExport_Click(object sender, EventArgs e)
        {
            Log.Export();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            // END LAN PLAY PROCESS ->

            Application.Exit();
        }
    }
}
