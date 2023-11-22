using System;

namespace Desktop
{
    class minMax
    {
        static void Main(string[] args)
        { 
        Console.WriteLine("enter your 5 numbers");
        var myNumbers = new double[5];
        for(int i = 0;i<myNumbers.Length;i++)
        {
            myNumbers[i]=Convert.ToDouble(Console.ReadLine());
        }
       var maxNum= findMaximum(myNumbers);
       var minNum = findMinimum(myNumbers);
       Console.WriteLine($"Yor maximum number is {maxNum}");
       Console.WriteLine($"Yor minimum number is {minNum}");
        }
        static double findMaximum(double[] numbers)
        {
            double maximum = numbers[0];
            foreach(var number in numbers){
                if(maximum <number){
                    maximum = number;
                }
            }
                return maximum;
        }
        static double findMinimum(double[] numbers)
        {
            double minimum = numbers[0];
            foreach(var number in numbers){
                if(minimum>number){
                    minimum= number;
                }
            }
                return minimum;
        }
    }   
}