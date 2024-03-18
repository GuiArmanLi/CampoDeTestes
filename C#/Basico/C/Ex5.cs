using System;

public class Ex5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a 1 nota do aluno");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2 nota do aluno");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;

        if (media == 10)
        {
            Console.WriteLine("Aprovado com distincao");
        }
        else if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else if (media < 7)
        {
            Console.WriteLine("Reprovado");
        }
        else
        {
            Console.WriteLine("Valor invalido");
        }
    }
}
