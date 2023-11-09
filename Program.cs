using System;

namespace Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            //* bmi calc
            Console.WriteLine("Please enter your weight by kilogram :");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height by meter :");
            double height = Convert.ToDouble(Console.ReadLine());
            var result = weight / Math.Pow(height, 2);
            switch(result){
            case result <= 18.5:
                Console.WriteLine("you are under weight");
                break;
            case 18.6 <= result <= 24.5:
                Console.WriteLine("you are Normal person");
                break;
            case 25 <= result <= 29.9:
                Console.WriteLine("you are over weight");
                break;
            default: 
                Console.WriteLine("you are obese person");
                break;
            }
        }

    }

}
