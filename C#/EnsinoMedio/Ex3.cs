using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)

        {
            {
                Double base1, i, expo, base2;
                Console.WriteLine("Digite a base: ");
                base1 = Convert.ToDouble(Console.ReadLine());
                base2 = base1;
                Console.WriteLine("Digite o expoente: ");
                expo = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                if (expo > 0)
                {
                    for (i = 1; i < expo; i++)
                    {
                        base1 = base2 * base1;
                    }
                    Console.WriteLine("Resultado � " + base1);
                }

                if (expo <= 0) { Console.WriteLine("Opera��o n�o � v�lida!"); }

                Console.ReadKey();
            }
        }
    }
}