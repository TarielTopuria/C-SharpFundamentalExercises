using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    class ContinuouslyCalculator
    {
        public static void continuouslyCalculator()
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter Number or 'ok' to Exit ");
                string input = Console.ReadLine();

                if(input.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    sum = Convert.ToInt32(input) + sum;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
