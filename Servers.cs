using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using Newtonsoft.Json;
using Switch_LAN_Play_GUI.Custom_Controls;

namespace Switch_LAN_Play_GUI
{
    class Servers
    {
        public static WindowMain windowMain;

        public static List<Server> List = new List<Server>();

        public static void PopulateList()
        {
            for (int i = 0; i < List.Count / 4; i++)
            {
                ServerListing listing = new ServerListing();
                listing.lServerAddress.Text = $"{List[i].ip}:{List[i].port}";
                listing.lServerLatency.Text = $"{ServerLatency(List[i].ip)}ms";
                listing.Width = windowMain.pServerList.Width - 25;

                if (listing.lServerLatency.Text != "--ms")
                    windowMain.pServerList.Controls.Add(listing);
            }
        }

        private static string ServerLatency(string domain)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            options.DontFragment = true;

            string data = "testing latency";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = null;

            try
            {
                reply = pingSender.Send(domain, timeout, buffer, options);
            }
            catch (Exception)
            {
                
            }

            if (reply.Status == IPStatus.Success)
                return $"{reply.RoundtripTime}";
            else
                return "--";
        }

        public static void ImportList()
        {

        }
    }

    public class Server
    {
        public string ip;
        public int port;
        public string flag;
        public string platform;
        public string type;
    }
}
