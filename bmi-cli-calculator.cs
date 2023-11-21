using System;

namespace Desktop
{
    class tvcontrol
    {
        static void Main(string[] args)
        {
            validation(args);
            Excecute(args);
        }
        static void validation(string[] args){
            if(args[0] != "bmi" || args.Length ==0){
                BadCommands();
                Environment.Exit(0);
            }else if(args[1]=="--helps"){
                ShowHelp();
                Environment.Exit(0);
            }else if( args[1]=="--versions"){
                ShowVersions();
                Environment.Exit(0);
            }
        }
        static void Excecute(string[] args){
            var firstSwitch = args[1];
            var firstArg = args[2];
            var secondSwitch = args[3];
            var secondArg = args[4];

            double weight,height;
            switch (firstSwitch)
            {
                case "--height":
                    if(secondSwitch != "--weight"){
                        BadCommands();
                        break;
                    }
                    height = Convert.ToDouble(firstArg);
                    weight = Convert.ToDouble(secondArg);
                    CalculateBMI(weight,height);
                    break;
                case "--weight":
                          if(secondSwitch != "--height"){
                        BadCommands();
                        break;
                    }
                    height = Convert.ToDouble(secondArg);
                    weight = Convert.ToDouble(firstArg);
                    CalculateBMI(weight,height);
                    break;
                default :
                    BadCommands();
                    break;
            }
        }
        static void CalculateBMI(double weight,double height){
            double bmi = weight / (Math.Pow(height, 2));
             if(bmi <= 18.5){
                Console.WriteLine("you are under weight");
            } 
            else if(18.6 <= bmi && bmi <= 24.5){
                Console.WriteLine("you are Normal person");

            }else if(25 <= bmi && bmi <= 29.9){
                Console.WriteLine("you are over weight");
            } 
             else{
                Console.WriteLine("you are obese person");
                }
        }
        static void BadCommands(){
            Console.WriteLine("This prompt is unnormal please read the help and try again");
            Console.WriteLine("for reading help enter dotnet run --helps");
             Environment.Exit(0);
        }
        static void ShowHelp(){
            Console.WriteLine("for calculating your bmi please enter your hieght and width like this");
            Console.WriteLine("dotnet run --height 1.75 --weight 85");
            Console.WriteLine("dotnet run --weight 1.75 --height 85");
            Console.WriteLine("for guide of console app : dotnet run --helps");
            Console.WriteLine("see the version of software : dotnet run --versions");
        }
        static void ShowVersions(){
            Console.WriteLine("version 1.0.0");
        }
    }
}