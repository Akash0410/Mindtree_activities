using System;

class Program {
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        int num = 2;
        
        while (count <n ) {
            bool isPrime = true;
            
            for (int i = 2; i <= Math.Sqrt(num); i++) {
                if (num % i == 0) {
                    isPrime = false;
                    break;
                }
            }
            
            if (isPrime) {
                Console.Write(num + " ");
                count++;
            }
            
            num++;
        }
    }
}
