using System;

public class Ex13
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite, de 1 a 7, o dia da semana.");
        int DiaDaSemana = int.Parse(Console.ReadLine());

        switch (DiaDaSemana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda");
                break;
            case 3:
                Console.WriteLine("Terca");
                break;
            case 4:
                Console.WriteLine("Quarta");
                break;
            case 5:
                Console.WriteLine("Quinta");
                break;
            case 6:
                Console.WriteLine("Sexta");
                break;
            case 7:
                Console.WriteLine("Sabado");
                break;
            default:
                Console.WriteLine("Entrada incorreta!");
                break;
        }
    }
}
