using System;
class Program{
    public static void Main(string[] args){
        double sum=0;
        Console.WriteLine("Enter the count");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n>0){
            Console.WriteLine("Enter numbers");
            for(int i=1;i<=n;i++){
                double num = Convert.ToDouble(Console.ReadLine());
                sum+=num;
            }
            double avg = sum/n;
        Console.WriteLine("Sum of numbers is {0:F1} average of numbers is {1:F1}",sum,avg);
        }else{
            Console.WriteLine("Invalid Input");
        }
        
    }
}   