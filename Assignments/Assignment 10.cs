using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string userNum = "";
            int num = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("Enter a number: ");
                userNum = Console.ReadLine();

                if (int.TryParse(userNum, out num))
                {
                    while (num % 2 == 0)
                    {
                        Console.WriteLine(2);
                        num = num / 2;
                    }

                    for (int i = 3; i <= Math.Sqrt(num); i = i + 2)
                    {
                        while (num % i == 0)
                        {
                            Console.WriteLine(i);
                            num = num / i;
                        }
                    }

                    if (num > 2)
                    {
                        Console.WriteLine(num);
                    }
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again.\n");
                }
            }
            Console.WriteLine("\nGoodbye!\n");
        }
    }
}
