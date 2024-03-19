using System;

class Ex23
{
    static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        double numero = double.Parse(Console.ReadLine());

        string result = numero == Math.Round(numero) ? "Inteiro" : "Decimal";

        Console.WriteLine(result);
    }
}