using System;

public class Ex12
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de sua hora:\t");
        double SalaryPerHour = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de horas trabalhadas:\t");
        double HourWorkedPerMonth = double.Parse(Console.ReadLine());

        double GrossSalary = SalaryPerHour * HourWorkedPerMonth;
        double IRPercent = 0;
        double INSS = 10;
        double Syndicate = 3;
        double FGTS = 0.11;
        double DiscountIR = 0;

        if (GrossSalary <= 900)
        {
            DiscountIR = 0;
        }
        else if (GrossSalary > 900 && GrossSalary <= 1500)
        {
            IRPercent = 5;
            DiscountIR = 0.05 * GrossSalary;
        }
        else if (GrossSalary > 1500 && GrossSalary <= 2500)
        {
            IRPercent = 10;
            DiscountIR = 0.10 * GrossSalary;
        }
        else
        {
            IRPercent = 20;
            DiscountIR = 0.20 * GrossSalary;
        }

        double INSSDiscount = GrossSalary * 0.10;
        double TotalDiscount = DiscountIR + INSSDiscount + Syndicate;

        Console.WriteLine("Salario Bruto (" + SalaryPerHour + " * " + HourWorkedPerMonth + " ):\tR$" + GrossSalary);
        Console.WriteLine("( - )IR(" + IRPercent + "%):\t\t\tR$" + DiscountIR);
        Console.WriteLine("( - )INSS:\t\t\tR$" + INSSDiscount);
        Console.WriteLine("FGTS (" + FGTS + "%):\t\t\tR$" + (GrossSalary * 0.11));
        Console.WriteLine("Total de descontos:\t\tR$" + TotalDiscount);
        Console.Write("Salario Liquido: \t\tR$" + (GrossSalary - TotalDiscount));
    }
}
