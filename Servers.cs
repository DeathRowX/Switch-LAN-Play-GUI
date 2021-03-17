using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Switch_LAN_Play_GUI
{
    class Servers
    {
        public static List<Server> List = new List<Server>();
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
