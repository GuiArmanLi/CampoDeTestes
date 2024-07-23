using System;

Console.WriteLine("Digite o valor de um Raio: ");
var raio = Double.Parse(Console.ReadLine());

CalcularValoresDoCirculo(raio, out object diametro, out double circunferencia, out double area);

Console.WriteLine(@$"
    Raio: {raio} 
    Diametro: {diametro}
    Area: {area}"
    );

static void CalcularValoresDoCirculo(double raio, out object diametro, out double circunferencia, out double area)
{
    diametro = raio * 2;
    circunferencia = 2 * Math.PI * raio;
    area = Math.PI * raio * 2;
}