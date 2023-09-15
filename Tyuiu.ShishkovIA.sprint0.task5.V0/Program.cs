using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShishkovIA.sprint0.task5.V0.lib;

namespace Tyuiu.ShishkovIA.sprint0.task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"A + B = {DataService.Addition(1, 5)}");
            Console.WriteLine($"A - B = {DataService.Subtracrtion(15, 5)}");
            Console.WriteLine($"A * B = {DataService.Multiplication(10, 10)}");
            Console.WriteLine($"A / B = {DataService.Division(9, 3)}");
            Console.ReadKey();
        }
    }
}
