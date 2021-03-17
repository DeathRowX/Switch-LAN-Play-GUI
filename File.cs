using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Switch_LAN_Play_GUI
{
    class File
    {
        public static void ExportText(string filename, string text)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write(text);
            }

            Log.Output($"[APPLICATION]: File exported as {filename}");
        }

        public static string ImportText(string filename)
        {
            string text = "";

            using (StreamReader reader = new StreamReader(filename))
            {
                text = reader.ReadToEnd();
            }

            Log.Output($"[APPLICATION]: File {filename} imported successfully");

            return text;
        }

        public static void ExportJson(string filename, List<Server> list)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write(JsonConvert.SerializeObject(list));
            }

            Log.Output($"[APPLICATION]: File exported as {filename}");
        }

        public static List<Server> ImportJson(string filename)
        {
            List<Server> list = new List<Server>();

            using (StreamReader reader = new StreamReader(filename))
            {
                string json = reader.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Server>>(json);
            }

            Log.Output($"[APPLICATION]: File {filename} imported successfully");

            return list;
        }

        public static bool Download(string url, string filename)
        {

            return false;
        }
    }
}
