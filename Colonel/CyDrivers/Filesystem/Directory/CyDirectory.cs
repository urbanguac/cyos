using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colonel.CyDrivers.Filesystem.File;

namespace Colonel.CyDrivers.Filesystem.Directory
{
    class CyDirectory
    {
        private string path; private CyFile[] files; private string name;
        public CyDirectory(string n, string apath) { path = apath; files = new CyFile[5]; name = n; }
        public string getPath() { return path; }
        public bool addFile(CyFile a) { for (int i = 0; i < files.Length; i++) { if (files[i] == null) { files[i] = a; return true; } } return false; }
        public bool fileExists(CyFile a) { return (path == a.getPath()); }
        public CyFile getFile(string name) { for (int i = 0; i < files.Length; i++) if (files[i].getName() == name) return files[i]; return null; }
        public string getName() { return name; }
        public CyFile[] getFiles()
        {
            int len = 0;
            for (int i = 0; i < files.Length; i++) if (files[i] != null) len++;
            CyFile[] fils = new CyFile[len]; int ind = 0;
            for (int i = 0; i < files.Length; i++) { if (files[i] != null) { fils[ind] = files[i]; ind++; } }
            return fils;
        }
        public string[] listFiles()
        {
            CyFile[] fils = getFiles();
            string[] filenames = new string[fils.Length];
            for (int i = 0; i < fils.Length; i++)
                filenames[i] = fils[i].getName();
            return filenames;
         }
    }
}
