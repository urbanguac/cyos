using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colonel.CyDrivers.Filesystem.File;
using Cosmos.Hardware2;

namespace Colonel.CyDrivers.Tools
{
    class Editor
    {
        public static void colorScreen()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void recolor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void edit(CyFile file)
        {
            colorScreen();
            Console.Clear(); //clear
            Console.WriteLine("Editing " + file.getName());
            Console.WriteLine();
            bool quit = false;
            string input="";
            string newContent = "";
            while (!quit)
            {
                input=Console.ReadLine();
                if (input == ":wq") quit = true;
                else newContent += input + "\n";
            }
            file.setContents(newContent);
            Console.Clear();
            Console.WriteLine("Edited successfully.");
            recolor();
        }
        public static void read(CyFile file)
        {
            
            colorScreen();
            Console.Clear();
            Console.WriteLine("Reading " + file.getName());
            Console.WriteLine();
            Console.WriteLine(file.getContents());
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Finished reading file.");
            recolor();
        }
    }
}
