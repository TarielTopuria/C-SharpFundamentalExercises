using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    class DivisibleNumber
    {
        public static void divisibleNumber()
        {
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }            
            Console.WriteLine(counter);
        }
    }
}
