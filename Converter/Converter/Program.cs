using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number");
            int num = 0;           
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("The Doubled Number Is " + num * 2);
            Console.ReadLine();

        }
    }
}
