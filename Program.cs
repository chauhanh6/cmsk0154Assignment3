using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmsk0154Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Person();
            Console.WriteLine(bob.IsValidated());

            Person kim = new Person("kim", "smith");
            Console.WriteLine(kim.IsValidated());
            Console.ReadLine();
        }
    }
}
