Console.WriteLine("Bom dia!!! Digite um numero que corresponde a um calculo matematico");
Console.WriteLine("1 - Area da Circuferencia");
Console.WriteLine("2 - Area do Retangulo");
Console.WriteLine("3 - Valor da Hipotenusa");
Console.WriteLine("4 - Area do Quadrado");

int operacao = Convert.ToInt16(Console.ReadLine());
switch (operacao)
{
    case 1:
        Console.WriteLine("Digite o valor do Raio");
        double raio = Convert.ToDouble(Console.ReadLine());

        double circunferencia = 2 * Math.PI * raio;

        Console.WriteLine("Circunferencia: " + circunferencia);
        break;

    case 2:
        Console.WriteLine("Digite o valor da Base");
        double @base = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor da Altura");
        double altura = Convert.ToDouble(Console.ReadLine());

        double area = @base * altura;
        Console.WriteLine("Area do Retangulo: " + area);
        break;

    case 3:
        Console.WriteLine("Digite o valor do primeiro Cateto");
        double catetoAdjacente = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor do segundo Cateto");
        double catetoOposto = Convert.ToDouble(Console.ReadLine());

        double hipotenusa = Math.Sqrt(Math.Pow(catetoAdjacente, 2) + Math.Pow(catetoOposto, 2));

        Console.WriteLine("Hipotenusa: " + hipotenusa);
        break;

    case 4:
        Console.WriteLine("Digite do Lado");
        double lado = Convert.ToDouble(Console.ReadLine());

        area = lado * 4;

        Console.WriteLine("Area do quadrado: " + area);
        break;

    default:
        Console.WriteLine("Digite um valor valido");
        break;
}