using System;

namespace Diamante.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            volta:
            Console.WriteLine("digite um numero impar");
            if (!(int.TryParse(Console.ReadLine(), out int x)) || x % 2 != 0)
            {
                                // 5-1 /2 = 2
                for (int i = 0; i < ((x - 1) / 2); i++)
                {
                    for (int z = 0; z < x; z++)
                    {                //((5-1)/2) 2 - 0
                        if (z >= ((x - 1) / 2) - i)
                        {
                            if (z > ((x - 1) / 2) + i)
                                break;
                            Console.Write("x");
                        }

                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                for (int i = ((x - 1) / 2); i < x; i++)
                {
                    for (int z = 0; z < x; z++)
                    {                       //((5-1)/2) 2 + (5-3) 2 = 4    
                        if (z > ((x - 1) / 2) - (x - i) )
                        {
                            if (z >= ((x - 1) / 2) + (x - i))
                                break;
                            Console.Write("x");
                        }

                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("valor invalido");
                Console.ResetColor();
                Console.ReadKey(true);  
                goto volta;
            }
        }
    }
}
