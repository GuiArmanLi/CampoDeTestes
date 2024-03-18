using System;

public class Ex17
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um ano para verificar se e Bissexto");
        int ano = int.Parse(Console.ReadLine());

        if (ano % 4 == 0) {
            Console.WriteLine("Ano bissexto!");
        } else
        {
            Console.WriteLine("Ano nao bissexto!");
        }
    }
}
