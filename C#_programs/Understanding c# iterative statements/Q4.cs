using System;

class Program {
    public static void Main(String[] args) {
        int n = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int i=1;i<=n;i++){
            fact*=i;
        }
        Console.WriteLine(fact);
    }
}