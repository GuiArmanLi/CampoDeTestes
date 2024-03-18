using System;

public class Ex8
{

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o preco de 3 produtos");

        double item1 = double.Parse(Console.ReadLine());
        double item2 = double.Parse(Console.ReadLine());
        double item3 = double.Parse(Console.ReadLine());

        if (item1 < item2 && item1 < item3)
        {
            Console.WriteLine("Compre o produto 1");
        }
        else if (item2 < item1 && item2 < item3)
        {
            Console.WriteLine("Compre o produto 2");
        }
        else
        {
            Console.WriteLine("Compre o produto 3");
        }
    }
}
