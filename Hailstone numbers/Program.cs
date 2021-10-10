using System;

namespace Hailstone_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
                Console.WriteLine("Write STOP for brake");
                Console.WriteLine("Enter int:");

                string input = Console.ReadLine();
                
                while (int.TryParse(input, out num))
                {
                    if (input == "STOP") break;
                    while(true)
                    {
                        
                        
                            if (num % 2 == 0)
                            {
                                num = num / 2;
                            }
                            else
                            {
                                num = num * 3;
                                num = num + 1;
                            }

                        System.Threading.Thread.Sleep(130);
                        Console.WriteLine(num);
                        if (num == 1) break;
                    }
                    break;

                }
                Console.WriteLine("Type 1 for close enter for restart");
                string closer = Console.ReadLine();
                if (closer == "1")
                {
                    break;
                }
                Console.Clear();
                

            }

        }
    }
}
