using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    public class NumberValidator
    {
        public static void numberValidator()
        {
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1: 
                    Console.WriteLine("Valid");
                    break;
                case 2:
                    Console.WriteLine("Valid");
                    break;
                case 3:
                    Console.WriteLine("Valid");
                    break;
                case 4:
                    Console.WriteLine("Valid");
                    break;
                case 5:
                    Console.WriteLine("Valid");
                    break;
                case 6:
                    Console.WriteLine("Valid");
                    break;
                case 7:
                    Console.WriteLine("Valid");
                    break;
                case 8:
                    Console.WriteLine("Valid");
                    break;
                case 9:
                    Console.WriteLine("Valid");
                    break;
                case 10:
                    Console.WriteLine("Valid");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
