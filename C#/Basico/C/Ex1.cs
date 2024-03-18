using System;

public class Ex1
{
    static void Main(string[] args) {
        Console.WriteLine("Digite 2 numeros");
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Primeiro numero digitado: " + numero1);
        Console.WriteLine("Segundo numero digitado: " + numero2);
    }
}
