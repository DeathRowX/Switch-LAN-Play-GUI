using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Switch_LAN_Play_GUI
{
    class Version
    {
        private static string major;
        private static string minor;
        private static string build;
        private static string revision;

        public static string Get()
        {
            System.Version version = Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);

            major = $"{buildDate.Year:0000}";
            minor = $"{buildDate.Month:00}";
            build = $"{buildDate.Day:00}";
            revision = $"{version.Revision * 2:00000}";

            return $"{major}.{minor}.{build}.{revision}";
        }

        /*
        Version will look like 
        YYYY.MM.DD.SSSSS
        2021.03.17.44100
        */
    }
}
