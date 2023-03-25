using System;

class Program {
    public static void Main(String[] args) {
        Console.WriteLine("Richter Magnitude: ");
       double mag = double.Parse(Console.ReadLine());
       if (mag<=2.4){
           Console.WriteLine("Micro");
       }else if(mag>=2.5 && mag<=5.4){
           Console.WriteLine("Light");
       }else if(mag>=5.5 && mag<=6.0){
           Console.WriteLine("Moderate");
       }else if(mag>=6.1 && mag<=6.9){
           Console.WriteLine("Strong");
       }else if(mag>=7.0 && mag<=7.9){
           Console.WriteLine("Major");
       }else{
           Console.WriteLine("Great");
       }
    }
}