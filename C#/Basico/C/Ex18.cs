using System;

public class Ex18
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma data no seguinte formato: dd/mm/aaaa");
        string date = Console.ReadLine();

        string dayStr = date[0].ToString() + date[1].ToString();
        string monthStr = date[3].ToString() + date[4].ToString();
        string yearStr = date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString();

        int day = int.Parse(dayStr);
        int month = int.Parse(monthStr);
        if (day < 0 || day > 31 ||
            month < 0 || month > 12)
        {
            Console.WriteLine("Data " + date + " invalida!");
        }
        else
        {
            Console.WriteLine("Data " + date + " valida!");
        }
    }
}
