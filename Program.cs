using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificacionISBN2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("(1)ISBN formato 10");
            Console.WriteLine("(2)ISBN formato 13");
            int resp = int.Parse(Console.ReadLine());


            switch (resp)
            {
                case (1):
                    int ISBN10;
                    int[] digit10 = new int[10];

                    Console.WriteLine("Validacion de ISBN 10");

                    for (int i = 0; i < 10; i++)
                    {
                        digit10[i] = int.Parse(Console.ReadLine());

                        if (digit10[i] > 9 || digit10[i] < 0)
                        {
                            Console.WriteLine("Valor invalido");
                            System.Environment.Exit(0);
                        }

                    }

                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(digit10[j]);
                    }

                    ISBN10 = ((digit10[0] * 10) + (digit10[1] * 9) + (digit10[2] * 8) + (digit10[3] * 7) + (digit10[4] * 6) + (digit10[5] * 5) + (digit10[6] * 4) + (digit10[7] * 3) + (digit10[8] * 2) + (digit10[9] * 1) % 11);

                    if (ISBN10 != 0)
                    {
                        Console.WriteLine(" ISBN invalido");
                    }
                    else if (ISBN10 == 0)
                    {
                        Console.WriteLine(" ISBN valido");
                    }

                    Console.ReadKey();

                    break;

                case (2):
                    int ISBN13;
                    int[] digit13 = new int[13];

                    Console.WriteLine("Validacion de ISBN 13");

                    for (int i = 0; i < 13; i++)
                    {
                        digit13[i] = int.Parse(Console.ReadLine());

                        if (digit13[i] > 9 || digit13[i] < 0)
                        {
                            Console.WriteLine("Valor invalido");
                            System.Environment.Exit(0);
                        }

                    }

                    ISBN13 = ((digit13[0] * 1) + (digit13[1] * 3) + (digit13[2] * 1) + (digit13[3] * 3) + (digit13[4] * 1) + (digit13[5] * 3) + (digit13[6] * 1) + (digit13[7] * 3) + (digit13[8] * 1) + (digit13[9] * 3) + (digit13[10] * 1) + (digit13[11] * 3) + (digit13[12] * 1) % 10);

                    for (int j = 0; j < 13; j++)
                    {
                        Console.Write(digit13[j]);
                    }

                    if (ISBN13 == 0)
                    {
                        Console.WriteLine(" ISBN valido");
                    }
                    else if (ISBN13 != 0)
                    {
                        Console.WriteLine(" ISBN invalido");
                    }

                    Console.ReadKey();

                    break;


                default:
                    break;
            }

           

        }
    }
}
