using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SibgatullinaAV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SibgatullinaAV.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 66));
            Console.WriteLine(DataService.Subtraction(70, 1));
            Console.WriteLine(DataService.Multiplication(7, 6));
            Console.WriteLine(DataService.Division(400, 2));
            Console.ReadKey();
        }
    }
}
