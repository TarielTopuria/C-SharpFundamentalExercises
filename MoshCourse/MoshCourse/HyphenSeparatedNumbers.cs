using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    public class HyphenSeparatedNumbers
    {
        public static void hyphenSeparatedNumbers()
        {
            Console.WriteLine("Enter numbers separated by a hyphen: ");
            String input = Console.ReadLine();
            bool includesDuplicates = false;

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = new List<int>();
            foreach (var number in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var uniqueNumber = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNumber.Contains(number))
                    uniqueNumber.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
        }
    }
}