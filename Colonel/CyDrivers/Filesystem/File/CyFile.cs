using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonel.CyDrivers.Filesystem.File
{
    class CyFile
    {
        private string contents; private string path; private string name;
        public CyFile(string aname, string apath) { contents = ""; path = apath; name=aname; }
        public string getContents() { return contents; }
        public bool setContents(string newContents)
        {
            try { contents = newContents; return true; }
            catch (Exception e) { return false; }
        }
        public bool empty() { return (setContents("")); }
        public string getPath() { return path; }
        public string getName() { return name; }
    }
}
