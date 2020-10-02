using System;

namespace Bastun
{
    class Program
    {
        public static double FahrToCelsius(int fahr)
        {
            double cel = (double)(fahr - 32) * 5 / 9;
            return cel;
        }

       
        static void Main(string[] args)
        {
            int celsius;
            int fahrenheit = 0;
            
            do
            {
                bool loop = true;
                do
                {

                    Console.Write("Enter Fahrenheit: ");
                    try
                    {
                        fahrenheit = int.Parse(Console.ReadLine());
                        loop = false;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input! Please enter only digits!");
                    }
                }
                while (loop);

                celsius = (int)FahrToCelsius(fahrenheit);
                                              

                if (celsius == 75)
                {
                    Console.WriteLine($"Temperature is now {MathF.Round(celsius, 2)} degrees celsius.");
                    Console.WriteLine("Perfect temperature! Let's get sweaty!");
                }
                else if (celsius < 73)
                {   
                    Console.WriteLine($"Temperature is now {MathF.Round(celsius, 2)} degrees celsius.");
                    Console.WriteLine("Way too cold, crank it up a bit!");
                }
                else if (celsius > 77)
                {
                    Console.WriteLine($"Temperature is now {MathF.Round(celsius, 2)} degrees celsius.");
                    Console.WriteLine("You'll get scolded, turn it down!");
                }
                else if (celsius >= 73 || celsius <= 77)
                {
                    Console.WriteLine($"Temperature is now {MathF.Round(celsius, 2)} degrees celsius.");
                    Console.WriteLine("Acceptable temperature, let's get into that sauna!");
                    break;
                }
            }
            while (celsius != 75);

            Console.WriteLine("Press any key to Exit the program.");
            Console.ReadKey(true);

        }
        public static void FahrToCelsius()
        { 
        }
            

    }
}
    