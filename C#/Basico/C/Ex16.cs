using System;
using System.Threading;

public class Ex16
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de C");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            return;
        }

        double Delta = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine("Delta: " + Delta);

        if (Delta < 0) {
            Console.WriteLine("Equacao nao possui raizes reais!");
        } else if (Delta == 0) {
            double Raiz = -b * Math.Sqrt(Delta) / 2 * a;
            Console.WriteLine("Raiz: " + Raiz);
        } else if (Delta > 0) {
            double RaizX = -b + Math.Sqrt(Delta) / 2 * a;
            double RaizY = -b - Math.Sqrt(Delta) / 2 * a;
            Console.WriteLine("Raiz X: " + RaizX + "\nRaiz Y: " + RaizY);
        }

        Thread.Sleep(5000);
    }
}
