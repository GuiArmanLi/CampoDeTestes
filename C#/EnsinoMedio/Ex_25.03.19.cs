int Numcalc = 0;
String calc = "";
double Cb, Ca, Ha, Raio, circunferencia, area, HR;

Console.WriteLine("Bom dia!!! Digite um n�mero que corresponde a um calculo matem�tico" +
    "\n" + "Para calcular a �rea da circunferencia digite 1." +
    "\n" + "Para calcular a �rea de um ret�ngulo digite 2" +
    "\n" + "Para calcular o valor da hipotenusa digite 3." +
    "\n" + "Para calcular a �rea de um quadrado digite 4");

Numcalc = Convert.ToInt16(Console.ReadLine());
switch (Numcalc)
{


    case 1:
        calc = "Voc� escolheu o calculo da �rea da circunferencia";
        Console.WriteLine("Digite o valor do raio");
        Raio = Convert.ToDouble(Console.ReadLine());
        circunferencia = 2 * 3.14 * Raio;
        Console.WriteLine("O valor da circunferencia �: " + circunferencia);
        Console.ReadKey(); break;




        double b, h;
    case 2:
        calc = "Voc� escolheu o calculo da �rea do ret�ngulo";
        Console.WriteLine("Digite o valor da base");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura");
        h = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        area = b * h;
        Console.WriteLine("A area do ret�ngulo �: " + area);
        Console.ReadKey(); break;


    case 3:
        calc = "Voc� escolheu o calculo da hipotenusa";
        Console.WriteLine("Digite o valor do primeiro cateto");
        Ca = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor do segundo cateto");
        Cb = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("A formula do teorema de Pit�goras � " +
        "b� + c� = H�");
        HR = Math.Pow(Ca, 2) + Math.Pow(Cb, 2);
        Ha = Math.Sqrt(HR);
        Console.WriteLine("O valor da hipotenusa �: " + Ha);
        Console.ReadKey(); break;




        double bq, aq, areaq;
    case 4:
        calc = "Voc� escolheu o calculo da �rea do quadrado";
        Console.WriteLine("Digite o valor da base");
        bq = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura");
        aq = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        areaq = bq * aq;
        Console.WriteLine("A area do quadrado �: " + areaq);
        Console.ReadKey(); break;

    default:
        Console.WriteLine("Digite um n�mero de 1 a 4");
        break;
}