using System;

public class Ex15
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe os 3 lados de um triangulo");
        double CatetoOposto = double.Parse(Console.ReadLine());
        double CatetoAdjascente = double.Parse(Console.ReadLine());
        double Hipotenusa = double.Parse(Console.ReadLine());

        if (CatetoAdjascente + CatetoOposto > Hipotenusa ||
            Hipotenusa + CatetoAdjascente > CatetoOposto ||
            CatetoOposto + Hipotenusa > CatetoAdjascente &&
            CatetoAdjascente > 0 && CatetoOposto > 0 && Hipotenusa > 0)
        {
            if (CatetoAdjascente == CatetoOposto && CatetoAdjascente == Hipotenusa)
            {
                Console.WriteLine("Triangulo Equilatero");
            }
            else if (CatetoAdjascente == CatetoOposto || CatetoAdjascente == Hipotenusa)
            {
                Console.WriteLine("Triangulo Isosceles");
            }
            else
            {
                Console.WriteLine("Triangulo Escanleno");

            }
        }
        else
        {
            Console.WriteLine("Numeros informados nao formam um triangulo!");
        }
    }
}
