using System;

namespace Diamante.ConsoleApp1
{
    internal class Program
    {
        static void mensagemErro()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("valor invalido");
            Console.ResetColor();
            Console.ReadKey(true);
        }
        static Tuple<bool, int> DigiteUmNumeroImpar()
        {
            Console.WriteLine("digite um numero impar");
            if ((!(int.TryParse(Console.ReadLine(), out int numero)) || numero % 2 == 0))
                return Tuple.Create(true, 0);
            else
                return Tuple.Create(false, numero);
        }

        static void Main(string[] args)
        {

            Tuple<bool, int> eUmNumeroParTuple;
        digiteDeNovo:
            eUmNumeroParTuple = DigiteUmNumeroImpar();
            if (eUmNumeroParTuple.Item1)
            {
                mensagemErro();
                goto digiteDeNovo;
            }
            int numeroDeAsterisitcos = eUmNumeroParTuple.Item2;
            DiamanteDeCima(numeroDeAsterisitcos);
            DiamanteDeBaixo(numeroDeAsterisitcos);
        }

        private static void DiamanteDeBaixo(int numeroDeAsterisitcos)
        {
            for (int i = ((numeroDeAsterisitcos - 1) / 2); i < numeroDeAsterisitcos; i++)
            {
                for (int z = 0; z < numeroDeAsterisitcos; z++)
                {                       //((5-1)/2) 2 + (5-3) 2 = 4    
                    if (z > ((numeroDeAsterisitcos - 1) / 2) - (numeroDeAsterisitcos - i))
                    {
                        if (z >= ((numeroDeAsterisitcos - 1) / 2) + (numeroDeAsterisitcos - i))
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

        private static void DiamanteDeCima(int numeroDeAsterisitcos)
        {
            for (int i = 0; i < ((numeroDeAsterisitcos - 1) / 2); i++)
            {
                for (int z = 0; z < numeroDeAsterisitcos; z++)
                {                //((5-1)/2) 2 - 0
                    if (z >= ((numeroDeAsterisitcos - 1) / 2) - i)
                    {
                        if (z > ((numeroDeAsterisitcos - 1) / 2) + i)
                            break;
                        Console.Write("x");
                    }

                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    }

