using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
//using Cosmos.Hardware;
using fs = Colonel.CyDrivers.Filesystem;
using Colonel.CyDrivers.Filesystem;
using tools = Colonel.CyDrivers.Tools;
using Colonel.CyDrivers.Tools;
using Colonel.CyDrivers.Networking;

namespace Colonel
{
    public class Kernel : Sys.Kernel
    {
        Lifetree baron; Helper Dev;
        protected override void BeforeRun()
        {
            Console.WriteLine("Booting up...");
            Console.WriteLine("Initializing Filsystem . . .");
            baron = new Lifetree();
            Editor.recolor();
            Dev = new Helper();
            //Time.WaitSeconds(5);
            Dev.displayHelp();
            Console.WriteLine("Rules:");
            Console.WriteLine("Every command must be 3 characters at least. Spaces can be used for blank characters.");
            Console.WriteLine("Anything can be written after those first three letters.");
        }

        protected override void Run()
        {
            //LOGIN
            Console.CursorVisible = true;
            Console.WriteLine("Welcome to CyOS. Please login with the administrative credentials provided to you.");
            Gauntlet.login(!Gauntlet.secure);
            //START MAIN
            string path="\\";
            fs.Directory.CyDirectory directory = new fs.Directory.CyDirectory("\\",path);
            fs.Directory.CyDirectory root = directory;
            baron.addDirectory(directory);
            while (true)
            {
                Console.Write(">: ");
                var input = Console.ReadLine();
                if (input.Substring(0, 6) == "please") { input = input.Substring(7); }
                switch (input.Substring(0, 3))
                {
                    case "hel": Dev.displayHelp(); break;
                    case "dir": 
                        if (directory.getName()==root.getName() && directory.getPath() == root.getPath())
                            IterateAndPrint.run(baron.listDirectories());
                        else IterateAndPrint.run(directory.listFiles());
                        break;
                    case "md ": baron.addDirectory(new fs.Directory.CyDirectory(input.Substring(3, input.Length - 3), path)); break;
                    case "mak": fs.File.CyFile file = new fs.File.CyFile(input.Substring(5, input.Length - 5), path); directory.addFile(file); Editor.edit(file); break;
                    case "cd ": fs.Directory.CyDirectory dire = baron.getDirectory(input.Substring(3, input.Length - 3)); if (dire != null) { path = path + dire.getName() + "\\"; directory = dire; } break;
                    default: 
                        switch(input.Substring(0,3))
                        {
                            case "gam": Ekosystem.showGames(); break;
                            case "hi ": Console.WriteLine("Hello!"); break;
                            case "cls": Console.Clear(); break;
                            case "ls ": IterateAndPrint.run(directory.listFiles()); break;
                            case "rea": try { fs.File.CyFile readthis = directory.getFile(input.Substring(5, input.Length - 5)); if (readthis != null) Editor.read(readthis); else Console.WriteLine("File not found."); }
                                catch (Exception e) { Console.WriteLine("Error accessing file."); } break;

                            default: Console.WriteLine("CDNE: Command Does Not Exist."); break;

                        }
                        break;
                }

            }
        }


    }
}
