using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAccess
{
    public sealed class SealedClass
    {
        int first, second;
        public SealedClass(int a, int b)
        {
            first = a;
            second = b;
            Console.WriteLine($"some protected digits from sealed class = {first} and {second}");
        }
    }
}
