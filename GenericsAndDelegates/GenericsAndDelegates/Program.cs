using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public delegate int myDel(int a, int b);

        static void Main(string[] args)
        {
                    
            Console.WriteLine("Del--->Output using del");
            myDel del = Delegates.add;
            Console.WriteLine(del(10, 12));

            Console.WriteLine("Del--->Output using func");
            Func<int,int, int> obj = Delegates.add;
            Console.WriteLine(obj(10, 1));

            Console.WriteLine("Del--->Output using func lambda");
            string name = "amol";
            Func<string, string> convert = s => s.ToUpper();
            Console.WriteLine(convert(name));

            Console.WriteLine("Generics--->Output 1");
            var result1 = Generics.compare<string>("A", "A");
            Console.WriteLine(result1);

            Console.WriteLine("Generics--->Output 2");
            var result2 = Generics.compare<int>(1, 2);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }

    class Generics
    {
        public static bool compare<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }

    class Delegates
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

    }
}
