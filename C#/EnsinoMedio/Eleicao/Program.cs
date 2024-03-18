using System;

class Program
{
    static void Main(string[] args)
    {
        String Gerlania, Dolores, Gertrudes, Abgail, Situacao;
        double Tpessoas = 0, Votos = 0, Gerl = 0, Do = 0, Gert = 0, Abg = 0, GerlP = 0, DoP = 0, GertP = 0, AbgP = 0, nulos = 0;

        Console.WriteLine("Eleicao de 2019!");
        Console.WriteLine("Participantes: " + "\n" + "Gerlania \nDolores \nGertrudes \nAbgail");
        Console.ReadKey();
        Console.Clear();


        Console.WriteLine("Digite o numero total de participantes");
        Tpessoas = Double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite o numero de votos de Gerlania");
        Gerl = Double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite o numero de votos de Dolores");
        Do = Double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite o numero de votos de Gertudes");
        Gert = Double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Digite o numero de votos de Abgail");
        Abg = Double.Parse(Console.ReadLine());
        Console.Clear();

        nulos = Tpessoas - (Gerl + Do + Gert + Abg);

        GerlP = Gerl * 100 / Tpessoas;

        DoP = Do * 100 / Tpessoas;

        GertP = Gert * 100 / Tpessoas;

        AbgP = Abg * 100 / Tpessoas;
        if (Gerl > Do || Gerl > Gert || Gerl > Abg)
            Situacao = "Gerlania ganhou a eleicao com " + GerlP + "% dos votos";

        else if (Do > Gerl || Do > Gert || Do > Abg)
            Situacao = "Dolores ganhou a eleicao com " + DoP + "% dos votos";

        else if (Gert > Gerl || Gert > Do || Gert > Abg)
            Situacao = "Gertudes ganhou a eleicao com " + GertP + "% dos votos";

        else if (Abg > Gerl || Abg > Do || Abg > Gert)
            Situacao = "Abigail ganhou a eleicao com " + AbgP + "% dos votos";

        else
            Situacao = "Houve corrupcao nessa votacao !!!";

        Console.WriteLine(Situacao + "\nNumero votos de nulos " + nulos);
        Console.ReadKey();
    }
}
