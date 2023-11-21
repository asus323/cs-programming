using System;

namespace Desktop
{
    class tvcontrol
    {
        static void Main(string[] args)
        {
            Console.WriteLine("your name: ");
            var myName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("your Age: ");
            var myAge = Convert.ToInt32(Console.ReadLine());
            personal_Information(myName,myAge);
        }

        static void personal_Information(string name , int age){
            Console.WriteLine($"Hello my name is {name} & I am {age} years old");
        }
    }
}