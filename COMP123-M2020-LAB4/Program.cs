using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person karamjit = new Person("Karamjit", age: 19);

            karamjit.SaysHello();

            Console.ReadLine();
        }
    }
}