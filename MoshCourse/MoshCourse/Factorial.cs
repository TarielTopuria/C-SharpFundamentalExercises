using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    class Factorial
    {
        public static void factorial()
        {
            Console.WriteLine("Enter number to calculate its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1; 

            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine("{0}! = {1}", number, result);
        }
    }
}
