using System;

namespace avaliacao_global
{
    class Program
    {
        static void Main(string[] args)
        {
             int numero = 20, i = 20;
            while (i != 1)
            {
                for (i = 20; i >= 2; i--)
                {
                    if (numero % i != 0)
                        break;
                }
                if (i == 1)
                {
                    Console.WriteLine($"O número {numero} é o que estamos procurando.");
                }
                else
                    numero += 20;
            }
        }
    }
}
