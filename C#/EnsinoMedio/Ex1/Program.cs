using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        Console.WriteLine("Os numeros sao:");
        for (i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
            Thread.Sleep(100);
        }
    }
}
