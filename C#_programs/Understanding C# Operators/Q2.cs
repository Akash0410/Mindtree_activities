using System;

class Program {
    public static void Main(String[] args) {
        int age = Convert.ToInt32(Console.ReadLine());
        if (age>=15 && age<=60){
            Console.WriteLine("Allowed");
        }else{
            Console.WriteLine("Not Allowed");
        }
    }
}