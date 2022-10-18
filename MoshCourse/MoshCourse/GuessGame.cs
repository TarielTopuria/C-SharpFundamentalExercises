using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshCourse
{
    class GuessGame
    {
        public static void guessGame()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 10);
            int tries = 4;
            int userNumber;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter number to guess, you have " + tries + " left");
                userNumber = Convert.ToInt32(Console.ReadLine());
                tries--;

                if (tries != 0) { 
                    if (userNumber == number)
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }
        }
    }
}
