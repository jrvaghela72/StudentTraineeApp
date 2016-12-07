using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageApp
{
    class DirectoryExitedException:Exception
    {
        public DirectoryExitedException():base(){}
        public DirectoryExitedException(string msg):base(msg){}
    }
}
