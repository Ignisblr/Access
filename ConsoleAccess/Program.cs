using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAccess
{
    class Man : AbstractHuman
    {
        string name;
        public enum Race { European, Negroid, Asian };

        public override string Name(string name)
        {
            this.name = name;
            return this.name;
        }

        public string GetRace(Race race)
        { return race.ToString(); }
    }
    class Program:Access
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Program program = new Program();
            //only inherit classes can use protected members
            //только классы-наслденики могут использовать защищенные члены класса(protected)
            program.DisplayPrivate(random.Next(0, 6), random.Next(0, 6));
            Console.WriteLine($"protected variable \"c\" = {program.c = random.Next(0, 6)}");
            Console.WriteLine($"private variable \"d\" = {program.d = random.Next(0, 6)}");
            program.DisplayInternal();
            program.f = 20;//мы не может напрямую обратиться к методу DisplayPublic(), т.к он закрыт
            //Но открыта переменная f и мы используем её
            Console.WriteLine($"public variable \"f\" = {program.f}");
            program.DisplayProtected(5,6);
            var some = StaticClass.SomeMethod(random.Next(0, 8));
            Console.WriteLine($"some static variable = {some}");
            
            Man man = new Man() { Sex = true, Age = 45, Length = 178, Weight=78};
            Console.WriteLine($"The man`s name is {man.Name("Bill")} and race is {man.GetRace(Man.Race.European)}");
            Console.ReadKey();
        }
    }
}
