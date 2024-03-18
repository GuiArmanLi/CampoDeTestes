using System;

public class Ex2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor");
        int valor = int.Parse(Console.ReadLine());

        if (valor < 0)
        {
            Console.WriteLine("Valor Negativo");
        }
        else
        {
            Console.WriteLine("Valor Positivo");
        }
    }
}
