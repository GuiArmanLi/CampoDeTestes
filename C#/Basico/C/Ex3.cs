using System;

public class Ex3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite [F] - Feminino ou [M] - Masculino");
        char letter = char.Parse(Console.ReadLine());
        if (letter == 'F')
        {
            Console.Write("Feminino");
        }
        else if (letter == 'M')
        {
            Console.WriteLine("Masculino");
        }
        else
        {
            Console.WriteLine("Entrada incorreta!");
        }
    }
}
