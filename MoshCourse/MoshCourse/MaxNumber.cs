using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    public class MaxNumber
    {
        public static int maxNumber()
        {
            Console.WriteLine("Enter First Number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            return Math.Max(number1, number2);
        }
    }
}
