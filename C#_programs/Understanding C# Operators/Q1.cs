using System;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter branding expenses");
        double b_exp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter travel expenses");
        double t_exp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter food expenses");
        double f_exp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter logistics expenses");
        double l_exp = Convert.ToDouble(Console.ReadLine());
        double total_exp = b_exp + t_exp + f_exp + l_exp;
        Console.WriteLine("Total expenses: Rs. {0:F2}", total_exp);
        Console.WriteLine("Branding expenses percentage: {0:F2}%", (b_exp / total_exp) * 100);
        Console.WriteLine("Travel expenses percentage: {0:F2}%", (t_exp / total_exp) * 100);
        Console.WriteLine("Food expenses percentage: {0:F2}%", (f_exp / total_exp) * 100);
        Console.WriteLine("Logistics expenses percentage: {0:F2}%", (l_exp / total_exp) * 100);
    }
}
