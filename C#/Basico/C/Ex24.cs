using System;

class Ex24
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro numero");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual operacao deseja realizar?");
        Console.WriteLine("[+] | [-] | [*] - [/]");
        char operacao = char.Parse(Console.ReadLine());

        double result = 0;
        switch (operacao)
        {
            case '+':
                result = numero1 + numero2;
                break;
            case '-':
                result = numero1 - numero2;
                break;
            case '*':
                result = numero1 * numero2;
                break;
            case '/':
                result = numero1 / numero2;
                break;
            default:
                Console.WriteLine("Entrada invalida");
                break;
        }

        Console.WriteLine("Resultado: " + result);
        if (result % 2 == 0)
        {
            Console.WriteLine("Numero e Par");
        }
        else
        {
            Console.WriteLine("Numero e Impar");
        }

        if (result > 0)
        {
            Console.WriteLine("Numero e Positivo");
        }
        else
        {
            Console.WriteLine("Numero e Negativo");
        }

        if (result == Math.Round(result))
        {
            Console.WriteLine("Numero e Inteiro");
        }
        else
        {
            Console.WriteLine("Numero e Decimal");
        }
    }
}