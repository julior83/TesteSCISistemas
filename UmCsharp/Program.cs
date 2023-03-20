using System;
using System.Net.Http.Headers;

namespace UmCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("Informe o numero desejado:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            if (numero1 % 2 == 0)
            {
                Console.WriteLine("O numero e par!");
            }
            else
            {
                Console.WriteLine("O numero e Impar");
            }

            {
                int numero2;

                Console.WriteLine("Informe o numero desejado:");
                numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero2 % 2 == 0)
                {
                    Console.WriteLine("O numero e par!");
                }
                else
                {
                    Console.WriteLine("O numero e Impar");
                }

                int numero3;

                Console.WriteLine("Informe o numero desejado:");
                numero3 = Convert.ToInt32(Console.ReadLine());

                if (numero3 % 2 == 0)
                {
                    Console.WriteLine("O numero e par!");
                }
                else
                {
                    Console.WriteLine("O numero e Impar");
                }


                int numero4;

                Console.WriteLine("Informe o numero desejado:");
                numero4 = Convert.ToInt32(Console.ReadLine());

                if (numero4 % 2 == 0)
                {
                    Console.WriteLine("O numero e par!");
                }
                else
                {
                    Console.WriteLine("O numero e Impar");
                }

                int numero5;

                Console.WriteLine("Informe o numero desejado:");
                numero5 = Convert.ToInt32(Console.ReadLine());

                if (numero5 % 2 == 0)
                {
                    Console.WriteLine("O numero e par!");
                }
                else
                {
                    Console.WriteLine("O numero e Impar");
                }
                int somarValores = numero1 + numero2 + numero3 + numero4 + numero5;
                float Media = somarValores / 5;
                Console.WriteLine($"A media dos Valores é:{Media}");
                Console.ReadKey();

            }
        }
    }
}
