using System;

class Program {
    public static void Main(String[] args) {
        int num = int.Parse(Console.ReadLine());
        int n = num/2;
        bool prime = true;
        for(int i =2;i<=n;i++){
            if (num%i==0){
                    prime = false;
            }
        }
        if(prime){
            Console.WriteLine("Prime");
        }else{
            Console.WriteLine("Not prime");
        }
    }
}