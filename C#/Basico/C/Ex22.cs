using System;

class Ex22
{
	static void Main(string[] args)
	{
		Console.WriteLine("Digite um numero inteiro");
		int numero = int.Parse(Console.ReadLine());

		if (numero % 2 == 0)
		{
			Console.Write("Par");
		}
		else
		{
			Console.Write("Impar");
		}
	}
}
