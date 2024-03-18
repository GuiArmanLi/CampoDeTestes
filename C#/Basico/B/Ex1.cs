using System;
using System.Threading;

public class Ex1
{
    static void Main(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Args " + i + ": " + args[i]);
            Thread.Sleep(1000);
        }
    }
}
