using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAccess
{
    static class StaticClass
    {
        static int someStatic;

        public static int SomeMethod(int digit)
        {
            someStatic = digit;
            return someStatic;
        }
    }
}
