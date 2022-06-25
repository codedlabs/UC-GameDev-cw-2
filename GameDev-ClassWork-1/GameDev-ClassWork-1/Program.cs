using System;

namespace GameDev_ClassWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // superhero
            int Mohammad = 20;
            String heroName = "Mohammad";
            double playerSpeed = 2.5;


            // vilan
            int Aziz = 2;
            String villainName = "Aziz";
            double villainSpeed = 1.5;

            // Check who is stronger 
            if (Mohammad > Aziz)
            {
                Console.WriteLine("{0} is stronger than {1}", heroName, villainName);
            }
            else
            {
                Console.WriteLine("{0} is stronger than {1}", villainName, heroName);
            }
            // Function I called it math and I want to check the speed of the villain
            void math() { 
            if(playerSpeed == villainSpeed)
            {
                Console.WriteLine("you all have the same speed");
            }
            else if (playerSpeed < villainSpeed)
            {
                    Console.WriteLine($"Villain is faster and this is the speed diffrentce is {villainSpeed - playerSpeed}");

            }
            else if (playerSpeed > villainSpeed)
                {
                    Console.WriteLine($"Hero is faster and this is the speed diffrentce {playerSpeed - villainSpeed}");
                }
            }
            // I called the Fucntion 
            math();
        }
    }
}
