using System;

class Ex26
{
    static void Main(string[] args)
    {
        const double PRECO_ALCOOL = 1.90;
        const double PRECO_GASOLINA = 2.50;

        Console.WriteLine("Digite quantos litros deseja.");
        double quantidadeDeLitros = double.Parse(Console.ReadLine());
        Console.WriteLine("[1] - Alcool | [2] - Gasolina");
        int tipoGasolina = int.Parse(Console.ReadLine());

        double precoTotal = 0;
        if (tipoGasolina == 1)
        {
            precoTotal = quantidadeDeLitros * PRECO_ALCOOL;
            if (quantidadeDeLitros < 20)
            {
                precoTotal *= 0.97;
            }
            else
            {
                precoTotal *= 0.95;
            }
        }
        else if (tipoGasolina == 2)
        {
            precoTotal = quantidadeDeLitros * PRECO_GASOLINA;
            if (quantidadeDeLitros < 20)
            {
                precoTotal *= 0.96;
            }
            else
            {
                precoTotal *= 0.94;
            }
        }
        else
        {
            Console.WriteLine("Entrada incorreta!");
        }

        Console.WriteLine("Preco final: " +  precoTotal);
    }
}