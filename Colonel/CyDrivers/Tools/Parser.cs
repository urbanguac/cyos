using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonel.CyDrivers.Tools
{
    class Parser
    {
        public static string parseHTML(string x)
        {
            string y = "";
            while (x.Length > 0)
            {
                if (x.Substring(0,1) == "<")
                {
                    //parse it
                }
                else x = x.Substring(1);
            }
            return y;
        }
    }
}
