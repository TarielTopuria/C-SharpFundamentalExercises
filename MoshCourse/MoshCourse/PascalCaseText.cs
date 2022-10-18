using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    public class PascalCaseText
    {
        public static void pascalCaseText()
        {
            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine();

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }
    }
}
