using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Numer Of Meters");
            int meters = 0;
            int.TryParse(Console.ReadLine(), out meters);

            Console.WriteLine("Please Enter \n1) For Feet \n2) For Yards");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);

            /* if (num == 1)
             {
                 Console.WriteLine(meters * 3.28 + " Feet");
             }
             if (num == 2)
             {
                 Console.WriteLine(meters * 1.093 + " Yards");
             }
            */
            switch (num)
            {
                case 2:Console.WriteLine(meters * 1.093 + " Yards");
                    break;
                case 1: Console.WriteLine(meters * 3.28 + " Feet");
                    break;
                default:
                    Console.WriteLine("Invalid Units");
                    break;
            }
            Console.ReadLine();

            Console.WriteLine("Enter The Numer Of Liters");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);

            Console.WriteLine("Please Enter \n1) For Fluid Ounce \n2) For Gill \n3) For Pint \n4) For Quart \n5) For Gallon \n6) For Tablespoon \n7) For Teaspoon \n8) For Cup");
            int Lnum = 0;
            int.TryParse(Console.ReadLine(), out Lnum);

            switch (Lnum)
            {
                case 1:
                    Console.WriteLine(liters * 33.814 + " US Fluid Ounces");
                    break;
                case 2:
                    Console.WriteLine(liters * 8.45351 + " Gills");
                    break;
                case 3:
                    Console.WriteLine(liters * 2.11338 + " Pints");
                    break;
                case 4:
                    Console.WriteLine(liters * 1.05669 + " Quarts");
                    break;
                case 5:
                    Console.WriteLine(liters * 0.264172 + " Gallons");
                    break;
                case 6:
                    Console.WriteLine(liters * 56.3121 + " Tablespoons");
                    break;
                case 7:
                    Console.WriteLine(liters * 202.884 + " Teaspoons");
                    break;
                case 8:
                    Console.WriteLine(liters * 4.16667 + " Cups");
                    break;
                default:
                    Console.WriteLine("Invalid Units");
                    break;
            }
            Console.ReadLine();

        }
    }
}
