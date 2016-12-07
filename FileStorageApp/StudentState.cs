using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageApp
{
    class StudentState
    {
        public static Boolean GetState(StudentProp std)
        {
            if (std.Subjects.Adbms<35 || std.Subjects.Se < 35|| std.Subjects.Ns < 35|| std.Subjects.Mc< 35|| std.Subjects.An < 35)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
