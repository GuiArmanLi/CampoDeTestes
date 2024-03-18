using System;

public class Ex11
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o salario do colaborador: \t");
        double Salary = double.Parse(Console.ReadLine());

        int Percent = 0;
        double IncreaseValue = 0;
        double NewSalary = 0;
        if (Salary <= 280)
        {
            Console.WriteLine("A");
            Percent = 20;
            NewSalary = Salary * (1 + (Percent / 100.0));
            IncreaseValue = NewSalary - Salary;
        }
        else if (Salary >= 280 && Salary < 700)
        {
            Percent = 15;
            Console.WriteLine("B");
            NewSalary = Salary * (1 + (Percent / 100.0)); ;
            IncreaseValue = NewSalary - Salary;
        }
        else if (Salary >= 700 && Salary < 1500)
        {
            Console.WriteLine("C");
            Percent = 10;
            NewSalary = Salary * (1 + (Percent / 100.0)); ;
            IncreaseValue = NewSalary - Salary;
        }
        else if (Salary >= 1500)
        {
            Console.WriteLine("D");
            Percent = 5;
            NewSalary = Salary * (1 + (Percent / 100.0)); ;
            IncreaseValue = NewSalary - Salary;
        }

        Console.WriteLine("Salario antes do reajuste:\t" + Salary);
        Console.WriteLine("Percentual aplicado:\t" + Percent);
        Console.WriteLine("Valor do aumento:\t" + IncreaseValue);
        Console.WriteLine("Novo salario apos aumento:\t" + NewSalary);
    }
}
