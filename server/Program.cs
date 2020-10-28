using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Program
    {
        public static Server server;

        static void Main(string[] args)
        {
            DBManager.Init();
            DBManager.Inst().OpenFile();
            server = new Server(28);
        }
    }
}
