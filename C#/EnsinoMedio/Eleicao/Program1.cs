using System.Collections;
using System.Diagnostics.CodeAnalysis;

int Quantidade_De_Participantes = Int16.Parse(Console.ReadLine());

Console.WriteLine("Eleicao de 2019");
Console.WriteLine("Adicione a quantidade de participantes\t");

var candidatos = new List<Candidato>();
for (int i = 0; i < Quantidade_De_Participantes; i++)
{
    Console.WriteLine("\nDigite o nome do " + (i + 1) + " candidato\t");
    string name = Console.ReadLine();

    Console.WriteLine("\nQuantos votos " + name + " recebeu?\t");
    int votes = Int16.Parse(Console.ReadLine());

    var candidato = new Candidato(name, votes);
    candidatos.Add(candidato);
}

candidatos.Sort(
    (candidato) => candidato.Votes.
    );

for (int i = 0; i < Quantidade_De_Participantes; i++)
{
    Console.WriteLine((i + 1) + " colocado: " + candidatos[i].Name);
}

Thread.Sleep(5000);

public class Candidato
{
    public Candidato(string Name, int Votes)
    {
        this.Name = Name;
        this.Votes = Votes;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Votes { get; set; }
}