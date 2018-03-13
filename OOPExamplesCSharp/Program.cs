using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamplesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();

            Console.WriteLine($"Computer type - {computer.GetType().Name}");

            var isComputer = computer is Computer;

            Console.WriteLine($"Is computer - {isComputer}");

            Console.ReadLine();
        }
    }
}
