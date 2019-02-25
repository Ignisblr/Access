using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAccess
{
    public class Access
    {
        int a; // все равно, что private int a;
        private int b; // поле доступно только из текущего класса
        protected int c; // доступно из текущего класса и производных классов
        internal int d; // доступно в любом месте программы
        protected internal int e; // доступно в любом месте программы и из классов-наследников
        public int f; // доступно в любом месте программы, а также для других программ и сборок   

        protected SealedClass digits;

        public void DisplayPrivate(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine($"private variable \"a\" = {a}");
            Console.WriteLine($"private variable \"b\" = {b}");
        }

        protected void DisplayInternal()
        {
            Console.WriteLine($"internal variable \"e\" = {e}");
        }

        protected void DisplayProtected(int a, int b)
        {
            digits = new SealedClass(a, b);            
        }

        private void DisplayPublic()
        {
            Console.WriteLine($"public variable \"f\" = {f}");
        }
    }
}
