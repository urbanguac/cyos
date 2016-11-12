using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonel.CyDrivers.Tools
{
    class IterateAndPrint
    {
        public static void run(string[] list)
        {
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}
