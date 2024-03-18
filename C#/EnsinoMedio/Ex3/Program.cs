using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testandoo elevacao");

        Console.WriteLine("Digite a base: ");
        double @base = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o expoente: ");
        double expoente = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(@base, expoente);

        Console.WriteLine("Resultado: " + result);

        Thread.Sleep(1000);
    }
}