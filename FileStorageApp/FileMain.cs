using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStorageApp
{
    class FileMain
    {
        public String  CreateMainDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                Directory.Delete(path, true);
                Directory.CreateDirectory(path);
            }
            return path;
        }

        public string CreateSubDirectory(string p,string foldername)
        {
            string path = Path.Combine(p,foldername);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                throw new DirectoryExitedException("Directory existed please use other name");
            }
            return path;
        }

        public String CreateParentFile(String path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                throw new Exception("File already existed");
            }
            return path;
        }
    }
}
