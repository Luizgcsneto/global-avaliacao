using System;

namespace avaliacao_global
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroUM = 10, i = 10;
            while (i != 1)
            {
                for (i = 10; i >= 2; i--)
                {
                    if (numeroUM % i != 0)
                        break;
                }
                if (i == 1)
                {
                    Console.WriteLine($"O número {numeroUM} é o que estamos procurando.");
                }
                else
                    numeroUM += 10;
            }

            
            // de 1 a 20
            int numero = 20, j = 20;
            while (j != 1)
            {
                for (j = 20; j >= 2; j--)
                {
                    if (numero % j != 0)
                        break;
                }
                if (j == 1)
                {
                    Console.WriteLine($"O número {numero} é o que estamos procurando.");
                }
                else
                    numero += 20;
            }
        }
    }
}
