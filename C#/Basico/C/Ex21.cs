using System;

class Ex21
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor, entre 10 e 600, que deseja sacar: ");

        int valorDoSaque = int.Parse(Console.ReadLine());

        if (valorDoSaque > 10 || valorDoSaque < 600)
        {
            int notasDe100 = valorDoSaque / 100;
            int notasDe50 = (valorDoSaque % 100) / 50;
            int notasDe10 = (valorDoSaque % 50) / 10;
            int notasDe5 = (valorDoSaque % 10) / 5;
            int notasDe1 = (valorDoSaque % 5) / 1;

            string result = "Saque de " + valorDoSaque + " = ";
            result += notasDe100 > 1 ? notasDe100 + " notas de 100 | " : notasDe100 + " nota de 100 | ";
            result += notasDe50 > 1 ? notasDe50 + " notas de 50 | " : notasDe50 + " nota de 50 | ";
            result += notasDe10 > 1 ? notasDe10 + " notas de 10 | " : notasDe10 + " nota de 10 | ";
            result += notasDe5 > 1 ? notasDe5 + " notas de 5 | " : notasDe5 + " nota de 5 | ";
            result += notasDe1 > 1 ? notasDe1 + " notas de 1 | " : notasDe1 + " nota de 1";

            Console.WriteLine(result);
        }
        else
        {
            Console.Write("Entrada invalida!");
        }
    }
}