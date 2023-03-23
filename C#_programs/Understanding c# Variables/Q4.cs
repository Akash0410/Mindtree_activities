using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Flight name :");
        string f_name = Console.ReadLine();
        Console.WriteLine("Enter Ticket No  :");
        string t_no = Console.ReadLine();
        Console.WriteLine("Enter Flight Fare :");
        string f_fare = Console.ReadLine();
        Console.WriteLine("Enter Travelling Class :");
        string t_class = Console.ReadLine();
        Console.WriteLine("Enter Source :");
        string src = Console.ReadLine();
        Console.WriteLine("Enter Destination :");
        string destn = Console.ReadLine();
        Console.WriteLine("Flight Details  :");
        Console.WriteLine($"Flight Name : {f_name}");
        Console.WriteLine($"Ticket No : {t_no}");
        Console.WriteLine($"Flight Fare : {f_fare}");
        Console.WriteLine($"Class : {t_class}");
        Console.WriteLine($"Source : {src}");
        Console.WriteLine($"Destination : {destn}");
    }
}
