using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyakhov_lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee3 worker = new Employee3();
            worker.Input();
            worker.Output();
            for (int i = 0; i <= 4; i++)
            {
                Employee3 newWorker = new Employee3();
                worker.Input();
                worker.Output();
            }
            Console.ReadLine();
        }
    }
}
