using System;

class Program {
    public static void Main(String[] args) {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        if (x>y &&x>z){
            Console.WriteLine(x+" is the maximum number");
        }else if(y>x &&y>z){
            Console.WriteLine(y+" is the maximum number");
        }else{
            Console.WriteLine(z+" is the maximum number");
        }
    }
}