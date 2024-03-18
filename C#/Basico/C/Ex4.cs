using System;

public class Ex4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma letra");
        char letter = char.Parse(Console.ReadLine());

        switch (letter)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Letra digitada e Vogal!");
                break;
            default:
                Console.WriteLine("Letra digitada e Consoante");
                break;
        }
    }
}
