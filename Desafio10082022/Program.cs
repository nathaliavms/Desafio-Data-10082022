using System;

namespace Desafio10082022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int a = int.Parse(Console.ReadLine());
            ImprimaTabuada(a);
        }

        static void ImprimaTabuada(int a)
        {
            
            for (int n = 1; n <= 10; ++n )
            {
                Console.WriteLine(n + " x " + a + " = " + n * a);
                
            }
        }
    }
}
