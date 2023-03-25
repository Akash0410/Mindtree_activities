using System;
class Program{
    public static void Main(string[] args){
        int range = int.Parse(Console.ReadLine());
            int start = 1;
            int sum = 3;
            int c = 4;
            Console.Write("1 ");
            for (int i = 2; i <= range; i++)
            {
                
                int d = start + sum + c;
                Console.Write(sum+" ");
                start = sum;
                sum = c;
                c = d;
                
            }
            
        }
    }
