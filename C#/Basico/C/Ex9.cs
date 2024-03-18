using System;

public class Ex9
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite 3 numeros");

        double numero1 = double.Parse(Console.ReadLine());
        double numero2 = double.Parse(Console.ReadLine());
        double numero3 = double.Parse(Console.ReadLine());

        double maior = 0;
        double menor = 0;
        double mediana = 0;

        if (numero1 > numero2 && numero1 > numero3)
        {
            maior = numero1;
        }
        else if (numero2 > numero1 && numero2 > numero3)
        {
            maior = numero2;
        }
        else
        {
            maior = numero3;
        }

        if (numero1 < numero2 && numero1 < numero3)
        {
            menor = numero1;
        }
        else if (numero2 < numero1 && numero2 < numero3)
        {
            menor = numero2;
        }
        else
        {
            menor = numero3;
        }

        if (numero1 < maior && numero1 > menor)
        {
            mediana = numero1;
        }
        else if (numero2 < maior && numero2 > menor)
        {
            mediana = numero2;
        }
        else
        {
            mediana = numero3;
        }
        Console.WriteLine(maior + ", " + mediana + ", " + menor);
    }
}
