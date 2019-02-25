using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAccess
{
    abstract class AbstractHuman
    {
        public int Length { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }

        public abstract string Name(string name);
    }
}
