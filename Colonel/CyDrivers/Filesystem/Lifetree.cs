using System;
using System.Collections.Generic;
using System.Text;
using SentinelKernel.System.FileSystem.VFS;
using System.IO;
using Sys = Cosmos.System;
using Cosmos.HAL;
using fs = Colonel.CyDrivers.Filesystem;
using Colonel.CyDrivers.Filesystem.Directory;
using Colonel.CyDrivers.Filesystem.File;
namespace Colonel.CyDrivers.Filesystem
{
    class Lifetree
    {
        private CyDirectory[] directories;
        public Lifetree() { directories = new CyDirectory[10]; }
        public bool addDirectory(CyDirectory direc)
        {
            for (int i = 0; i < directories.Length; i++) { if (directories[i] == null) { directories[i] = direc; return true; } }
            return false;
        }
        public CyDirectory[] getDirectories()
        {
            int len = 0;
            for (int i = 0; i < directories.Length; i++) if (directories[i] != null) len++;
            CyDirectory[] direcs = new CyDirectory[len]; int ind=0;
            for (int i = 0; i < directories.Length; i++) { if (directories[i] != null) { direcs[ind] = directories[i]; ind++; } }
            return direcs;
        }
        public string[] listDirectories()
        {
            CyDirectory[] direcs = getDirectories();
            string[] dirnames = new string[direcs.Length];
            for (int i = 0; i < direcs.Length; i++)
                dirnames[i] = direcs[i].getName();
            return dirnames;
        }
        public CyDirectory getDirectory(string name)
        {
            for (int i = 0; i < directories.Length; i++)
                if (directories[i] != null && directories[i].getName() == name)
                    return directories[i];
            return null;
        }
        


//        public static VFSBase vfs;
//        public static string path = "0:\\";
//        public static void init()
//        {
//            vfs = new SentinelVFS();
//            VFSManager.RegisterVFS(vfs);
//            Console.WriteLine("Filesystem loaded. Lifetree is on and all leaves are green.");
//        }
//        public static void index(string directory)
//        {
//            string dir = directory + VFSBase.DirectorySeparatorChar;
            
////            if (vfs.GetDirectory(path+directory) != null) path = path + directory + "\\";
//        }
//        public static void index()
//        {
//           // if (vfs.GetDirectory(path) != null) { }
////           string directory = 
//        }

//        public static void listAll()
//        {
//            int lines = 0;
//            try
//            {
//                //Directory.GetDirectories(path);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//                Console.WriteLine(lines);
//            }
//        }
    }
}
