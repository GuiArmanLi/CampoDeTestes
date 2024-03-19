using System;

class Ex19
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero entre 0 e 1000");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0 && numero < 1000)
        {
            int centenas = numero / 100;
            int dezenas = (numero % 100) / 10;
            int unidades = (numero % 10) / 1;

            string response = numero + " = ";
            response += centenas > 1 ? centenas + " centenas " : centenas + " centena ";

            response += dezenas > 1 ? dezenas + " dezenas " : dezenas + " centena ";

            response += unidades > 1 ? unidades + " unidades " : unidades + " unidade ";

            Console.WriteLine(response);
        }
        else
        {
            Console.WriteLine("Entrada invalida!");
        }
    }
}