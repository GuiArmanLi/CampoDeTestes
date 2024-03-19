using System;

class Ex27
{
    static void Main(string[] args)
    {
        const double PRECO_POR_KG_MORANGO = 2.50;
        const double PRECO_POR_KG_MACAS = 1.80;

        Console.Write("Quantos Kg de morango deseja?");
        double quantidadeKgMorango = double.Parse(Console.ReadLine());

        Console.Write("Quantos Kg de macas deseja?");
        double quantidadeKgMacas = double.Parse(Console.ReadLine());

        double precoTotal = 0;
        if (quantidadeKgMorango > 5)
        {
            precoTotal += (PRECO_POR_KG_MORANGO * quantidadeKgMorango) * 0.88;
        }
        else
        {
            precoTotal += PRECO_POR_KG_MORANGO * quantidadeKgMorango;
        }

        if (quantidadeKgMacas > 5)
        {
            precoTotal += (PRECO_POR_KG_MACAS * quantidadeKgMacas) * 0.83;
        }
        else
        {
            precoTotal += PRECO_POR_KG_MACAS * quantidadeKgMacas;
        }

        if (quantidadeKgMacas + quantidadeKgMorango > 8 ||
            precoTotal > 25)
        {
            precoTotal *= 0.90;
        }

        Console.WriteLine("Valor total: " + precoTotal);
    }
}
