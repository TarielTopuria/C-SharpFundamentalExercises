using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    public class HyphenChecker
    {
        public static void hyphenChecker()
        {
            Console.WriteLine("Enter numbers separated by hyphen: ");
            String inputed = Console.ReadLine();
            bool isConsecutive = true;

            List<int> ints = new List<int>();
            
            foreach(var input in inputed.Split("-"))
            {
                ints.Add(Convert.ToInt32(input));
                ints.Sort();
            }

            for (int i = 1; i < ints.Count; i++)
            {
                if((ints[i] != ints[i - 1] + 1))
                {
                    isConsecutive = false;
                    break;
                }
            }

            String result = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(result);
        }
    }
}
