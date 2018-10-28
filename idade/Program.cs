using System;
using System.Collections.Generic;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, maiorIdade = 0, menorIdade = 0;
            for(int i = 1; i<=3; i++)
            {
                Console.WriteLine("Informe a idade: ");
                idade = Int32.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    maiorIdade++;
                }
                else
                {
                    menorIdade++;
                }              
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ha {0} pessoa(s) maior(es) de idade", maiorIdade);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ha {0} pessoa(s) menor(es) de idade", menorIdade);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
