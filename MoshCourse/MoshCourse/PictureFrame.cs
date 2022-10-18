using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MoshCourse
{
    class PictureFrame
    {
        public static void pictureFrame()
        {
            Console.WriteLine("Enter width of the image: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of the image: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("the image is landscape");
            }
            else
            {
                Console.WriteLine("the image is portrait");
            }
        }
    }
}
