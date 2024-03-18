using System;

public class Class1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a 1 nota do aluno");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a 2 nota do aluno");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;

        Console.WriteLine("Nota 1:" + nota1 + "Nota 2:" + nota2);
        Console.WriteLine("Media:" + media);
        if (media < 4 && media >= 0)
        {
            Console.Write("Conceito E");
            Console.WriteLine("Reprovado")
        }
        else if (media < 6)
        {
            Console.Write("Conceito D");
            Console.WriteLine("Reprovado")
        }
        else if (media < 7.5)
        {
            Console.Write("Conceito C");
            Console.WriteLine("Aprovado")
        }
        else if (media < 9)
        {
            Console.Write("Conceito B");
            Console.WriteLine("Aprovado")
        }
        else if (media <= 10)
        {
            Console.Write("Conceito A");
            Console.WriteLine("Aprovado")
        }
        else
        {
            Console.Write("Entrada de valores incorretos");
        }
    }
}

