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

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    text = reader.ReadToEnd();
                }
                Log.Output($"[APPLICATION]: File {filename} imported successfully");
            }
            catch (Exception)
            {
                Log.Output($"[APPLICATION]: Failed to import file {filename}");
            }

            return text;
        }

        public static void ExportJson(string filename, dynamic list)
        {
            //Log.Output("[ERROR]: ImportJson(filename, list) not working. Use File.ExportText(filename, JsonConvert.SerializeObject(List<type>)) instead");
            //return;

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.Write(JsonConvert.SerializeObject(list));
            }

            Log.Output($"[APPLICATION]: File exported as {filename}");
        }

        public static void ImportJson(string filename, dynamic list)
        {
            Log.Output("[ERROR]: ExportJson(filename, list) not working. Use List<type> = JsonConvert.DeserializeObject<List<type>>(File.ImportText(filename)) instead");
            return;

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string json = reader.ReadToEnd();
                    list = JsonConvert.DeserializeObject<dynamic>(json);
                }
                Log.Output($"[APPLICATION]: File {filename} imported successfully");
            }
            catch (Exception)
            {
                Log.Output($"[APPLICATION]: Failed to import file {filename}");
            }
        }

        public static bool Download(string url, string filename)
        {

            return false;
        }
    }
}
