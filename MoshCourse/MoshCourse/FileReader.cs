using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    public class FileReader
    {
        public static void fileReader()
        {
            String pathLink = @"C:\Users\TTopuria\source\repos\MoshCourse\TrainingText.txt";
            String text = File.ReadAllText(pathLink);
            Console.WriteLine(text);
        }
    }
}
