using System;

class Program {
    public static void Main(String[] args) {
       int x = Convert.ToInt32(Console.ReadLine());
       if (x%2==0){
           Console.WriteLine($"{x} is an even number");
       }else{
           Console.WriteLine($"{x} is an odd number");
       }
    }
}