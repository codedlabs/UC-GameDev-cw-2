using System;

namespace Day_2_GameDev
{
    class Program
    {
        static void Main(string[] args)
        {
            


            

            void math()
            {
                Random rd = new Random();
                int number1 = 1;
                int number2 = 1;
                int number3 = 1;
                int health = 3;
                int score = 1;
                while (true)
                {
                    if (health <= 0)
                    {
                        Console.WriteLine("you lost all your health and this is your score {0} ",score);
                        Environment.Exit(0);

                    }
                    int randomNum1 = rd.Next(1, number1);
                    int randomNum2 = rd.Next(1, number2);
                    int randomNum3 = rd.Next(1, number3);

                    int addonsRand = randomNum1 + randomNum2 + randomNum3;
                    int productRand = randomNum1 * randomNum2 * randomNum3;

                    Console.WriteLine("guess the 3 numbers \nthe numbers addon too {0}\nthe product too {1}\nHEART LEFT {2}❤️",addonsRand,productRand,health);
                    
                    Console.WriteLine("Enter your first guess");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your Second guess");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your Third guess");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    int addons = num1 + num1 + num3;
                    int product = num1 * num2 * num3;

                    if (addons == addonsRand && product == productRand)
                    {
                        number1 += 1;
                        number1 += 1;
                        number1 += 1;
                        score += 1;
                        continue;
                    }
                    else
                    {
                        health -= 1;
                        Console.WriteLine("Wrong you lost a health bar 💔\nHEART LEFT {0}",health);
                        continue;

                    }
                }
            }
            math();
        }
    }
}
