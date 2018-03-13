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
            var computer = new Desktop(name: "Generic Computer", caseType: CaseType.Tower);

            Console.WriteLine($"Computer type - {computer.GetType().Name}");

            var isComputer = computer is Computer;

            Console.WriteLine($"Is computer - {isComputer}");

            Console.WriteLine($"The name of the computer is - {computer.Name}");
            Console.WriteLine($"The name of the computer case is - {computer.CaseType}");

            computer.TogglePower();
            Console.WriteLine($"Computer is on - {computer.IsOn}");

            Console.ReadLine();
        }
    }
}
