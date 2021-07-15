using System;

namespace Karica
{
    class Program
    {
        static void Main(string[] args)
        {
            // faza 1
            int n;
            Console.WriteLine("Vnesi višino lika");
            n = Convert.ToInt32(Console.ReadLine());
            int breaks = n / 2;
            for(int i = 0; i <= n/2; i++)
            {
                for(int k = 0; k < breaks; k++)
                {
                    Console.Write(" ");
                }
                breaks--;
                for(int j = 0; j < i*2+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            breaks = 1;
            for(int i = n/2 - 1; i >= 0; i--)
            {
                for (int k = 0; k < breaks; k++)
                {
                    Console.Write(" ");
                }
                breaks++;
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            // faza 2 obroba kare
            Console.WriteLine("");

            breaks = n / 2;
            for (int i = 0; i <= n / 2; i++)
            {
                for (int k = 0; k < breaks; k++)
                {
                    Console.Write(" ");
                }
                breaks--;
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    if(j == 0 || j == i * 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine("");
            }
            breaks = 1;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                for (int k = 0; k < breaks; k++)
                {
                    Console.Write(" ");
                }
                breaks++;
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    if (j == 0 || j == i * 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }

            // faza 2 papirnati zmaj
            Console.WriteLine("");

            breaks = n / 2;
            for (int i = 0; i <= n / 2; i++)
            {
                for (int k = 0; k < breaks; k++)
                {
                    Console.Write(" ");
                }
                breaks--;
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    if (j == 0 || j == i * 2 || j == i || i == n/2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
            breaks = 1;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                for (int k = 0; k < breaks; k++)
                {
                    Console.Write(" ");
                }
                breaks++;
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    if (j == 0 || j == i * 2 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
