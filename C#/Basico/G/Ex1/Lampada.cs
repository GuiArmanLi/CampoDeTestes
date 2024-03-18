using System;

public class Lampada
{
    string marca;
    double preco;

    public Lampada()
    {
    }

    public Lampada(string marca, double preco)
    {
        this.marca = marca;
        this.preco = preco;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Gostaria de criar uma lampada com atributos?");
        Console.WriteLine("[S] | [N]");
        char existAttributeInLamp = char.Parse(Console.ReadLine());

        Lampada lampada = null;
        if (existAttributeInLamp == 'S')
        {
            Console.WriteLine("Digite a Marca e o Preco da lampadas");
            string marca = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine());

            lampada = new Lampada(marca, preco);
        }
        else
        {
            lampada = new Lampada();
        }

        Console.WriteLine("Marca: " + lampada.marca);
        Console.WriteLine("Preco: " + lampada.preco);
    }
}
