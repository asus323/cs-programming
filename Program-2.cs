using System;

namespace second_program_in_c_
{
    class Program
    {
        static void Main(string[] args)
        {
        var exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter a number to execute :");
            Console.WriteLine("1) Convert number to alphabet");
            Console.WriteLine("2) Convert number to get the equal day of week");
            Console.WriteLine("3) Exit");
            Console.WriteLine("--> ");
            var menu = Convert.ToInt32(Console.ReadLine());
            switch(menu){
                case 1: 
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1 to 10 :");
                    var digit = Convert.ToInt32(Console.ReadLine());
                    var result = "";
                    switch(digit){
                        case 1:
                            result = "One";
                            break;
                        case 2 : 
                            result = "Two";
                            break;
                        case 3 :
                            result="Three";
                            break;
                        case 4 :
                            result = "four";
                            break;
                        case 5 :
                            result = "five";
                            break;
                        case 6 :
                            result = "six";
                            break;

                        case 7 :
                            result = "Seven";
                            break;
                        case 8 :
                            result = "eight";
                            break;
                        case 9 :
                            result = "Nine";
                            break;
                        case 10 :
                            result = "Ten";
                            break;
                        default : 
                            Console.WriteLine("You entered out of range number");
                            break;
                    }
                    if(!string.IsNullOrEmpty(result))
                        Console.WriteLine($"Your result is --> {result}");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2: 
                Console.Clear();
                Console.WriteLine("Please enter a number between 1 to 7 to get the equal day of week");
                var numberOfTheDay =Console.ReadLine();
                var dayOfWeek = "";
                switch(numberOfTheDay){
                    case "1" :
                        dayOfWeek = "Saturday";
                        break;
                    case "2" :
                        dayOfWeek = "Sunday";
                        break;
                    case "3" :
                        dayOfWeek = "Monday";
                        break;
                    case "4" :
                        dayOfWeek = "TuesDay";
                        break;
                    case "5" :
                        dayOfWeek = "WednesDay";
                        break;
                    case "6" :
                        dayOfWeek = "ThursDay";
                        break;
                    case "7" :
                        dayOfWeek = "FriDay";
                        break;
                    default :
                        dayOfWeek ="Invalid number";
                        break;
                } 
                    if(!string.IsNullOrEmpty(dayOfWeek))
                        Console.WriteLine($"Today is --> {dayOfWeek}");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                Console.Clear();
                Console.WriteLine("Good BYE :)");
                 ;
                 exit = true;
                break;
                default :
                Console.WriteLine("You Entered Wrong Number please enter numbers between 1 & 3");
                Console.ReadLine();
                Console.Clear();
                break;
            }

        }

        }
    }
}
