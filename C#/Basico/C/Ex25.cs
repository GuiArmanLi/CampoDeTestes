using System;

class Ex25
{
    static void Main(string[] args)
    {
        Console.WriteLine("Responda o formulario, [1] para Sim e [0] para Nao");
        int sum = 0;

        Console.WriteLine("Telefonou para a vitima?");
        sum += int.Parse(Console.ReadLine());

        Console.WriteLine("Esteve no local do crime?");
        sum += int.Parse(Console.ReadLine());

        Console.WriteLine("Mora perto da vitima?");
        sum += int.Parse(Console.ReadLine());

        Console.WriteLine("Devia para a vitima?");
        sum += int.Parse(Console.ReadLine());

        Console.WriteLine("Ja trabalhou com a vitima?");
        sum += int.Parse(Console.ReadLine());

        if (sum == 2)
        {
            Console.WriteLine("Suspeita");
        }
        else if (sum == 3 || sum == 4)
        {
            Console.WriteLine("Cumplice");
        }
        else if (sum == 5)
        {
            Console.WriteLine("Assassino");
        }
        else
        {
            Console.WriteLine("Inocente");
        }
    }
}