using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    class SpeedLimit
    {
        public static void speedLimit()
        {
            int demeritPoint = 0;
            Console.WriteLine("Enter Speed Limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Car Speed: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            
            for (int i = carSpeed; i >= (speedLimit + 5); i-=5)
            {
                demeritPoint++;
            }

            if(demeritPoint >= 12)
            {
                Console.WriteLine("Demerit point is " + demeritPoint);
                Console.WriteLine("Demerit points is above 12, so License is Suspended");
            }
            else
            {
                Console.WriteLine("Demerit point is " + demeritPoint);
                Console.WriteLine("Demerit points is below 12, so License is not Suspended");
            }
        }
    }
}
