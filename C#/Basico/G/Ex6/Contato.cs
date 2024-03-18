using System;

class Contato
{
    string name;
    string lastName;
    long phoneNumber;

    Contato() { }
    Contato(
        string name,
        string lastName,
        long phoneNumber)
    {
        this.name = name;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
    }

    static void Main(string[] args)
    {
        Contato contato = new Contato("Guilherme", "Pessa", 11946867628);
        Console.WriteLine(contato.name);
        Console.WriteLine(contato.lastName);
        Console.WriteLine(contato.phoneNumber);
    }
}