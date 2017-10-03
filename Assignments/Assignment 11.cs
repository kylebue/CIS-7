using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Assignment11
    {
        static void Main(string[] args)
        {
            AskForNums();
        }

        static void AskForNums()
        {
            string userNum1 = "";

            while (userNum1 != "q")
            {
                userNum1 = "";
                string userNum2 = "";
                int num1 = 0;
                int num2 = 0;
                bool isValidResponse = false;
                int result = 0;

                Console.WriteLine("Enter a number (press 'q' to quit): ");
                userNum1 = Console.ReadLine();

                if (int.TryParse(userNum1, out num1))
                {
                    num1 = Convert.ToInt32(userNum1);
                    
                    while (!isValidResponse)
                    {
                        Console.WriteLine("\nEnter another number: ");
                        userNum2 = Console.ReadLine();

                        if (int.TryParse(userNum2, out num2))
                        {
                            isValidResponse = true;
                            num2 = Convert.ToInt32(userNum2);

                            result = FindGCD(num1, num2);
                            Console.WriteLine("\nThe Greatest Common Divisor is: " + result + "\n");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid response. Try again.\n");
                        }
                    }
                }
                else if (userNum1 == "q")
                {
                    Console.WriteLine("\nGoodbye!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid response. Try again.\n");
                }
            }
        }

        static int FindGCD(int num1, int num2)
        {
            int minNum = 0;
            int GCD = 0;
            minNum = Math.Min(num1, num2);
            
            for (int i = minNum + 1; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    GCD = i;
                    break;
                }
            }

            return GCD;
        }
    }
}
