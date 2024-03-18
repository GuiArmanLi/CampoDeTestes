using System;

class ContaCorrente
{
    int number;
    double balance;
    bool isSpecial;
    double limit;

    ContaCorrente() { }

    ContaCorrente(
        int number,
        double balance,
        bool isSpecial,
        double limit)
    {
        this.number = number;
        this.balance = balance;
        this.isSpecial = isSpecial;
        this.limit = limit;
    }

    static void Main(string[] args)
    {
        ContaCorrente contaCorrente = new ContaCorrente(6, 600, false, 250000);

        Console.WriteLine(contaCorrente.ToString());
    }
}