using System;

public class Ex6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite 3 numeros");

        double numero1 = double.Parse(Console.ReadLine());
        double numero2 = double.Parse(Console.ReadLine());
        double numero3 = double.Parse(Console.ReadLine());

        if (numero1 > numero2 && numero1 > numero3)
        {
            Console.WriteLine("Numero 1 tem maior valor");
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            Console.WriteLine("Numero 2 tem maior valor");
        }
        else
        {
            Console.WriteLine("Numero 3 tem maior valor");
        }
    }
}
