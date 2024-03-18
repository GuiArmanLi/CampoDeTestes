using System;

public class Ex10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite [M] - Matutino | [V] - Vespertino | [N] - Noturno");
        char letter = char.Parse(Console.ReadLine());

        if (letter == 'M')
        {
            Console.WriteLine("Bom dia");
        }
        else if (letter == 'V')
        {
            Console.WriteLine("Boa tarde");
        }
        else
        if (letter == 'N')
        {
            Console.WriteLine("Boa noite");
        }
        else
        {
            Console.WriteLine("Digito invalido!");

        }
    }
}
