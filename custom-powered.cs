using System;

namespace Desktop
{
    class customPoweredData
    {
        static void Main(string[] args)
        {  
            validation(args);
            excecute(args);     
        }
        static double customPow(double num, double pow){
            double result =1;
            if(pow< 0){
            for(int i=1;i<=pow;i++){
            result /=num;
            }
            }else{
            for(int i=1;i<=pow;i++){
            result *=num;
            }
            }
            return result;
        }
        static void ShowVersions(){
        Console.WriteLine("this is version 1.0");
        }
        static void showHelps(){
        Console.WriteLine("for  calculating the  enter these commands");
        Console.WriteLine("dotnet run cliPow --number 2 --power 3");
        }
        static void BadCommands(){
        Console.WriteLine("you entered wrong command please enter --helps to show you how to use the software");
        Console.WriteLine("dotnet run cliPow --helps");
        }
        static void validation(string[] args){
            if(args[0] != "--cliPow" || args.Length == 0){
                BadCommands();
                Environment.Exit(0);
            }else if(args[1] == "--helps"){
                showHelps();
                Environment.Exit(0);
            }else if(args[1] == "--versions"){
                ShowVersions();
                Environment.Exit(0);
            }
        }
        static void excecute(string[] args){
            var firstSwitch =args[1];
            var firstArg =args[2];
            var secondSwitch =args[3];
            var secondArg =args[4];
            double firstArgD= Convert.ToDouble(firstArg);
            double secondArgD= Convert.ToDouble(secondArg);
            var result2= customPow(firstArgD,secondArgD);
            Console.WriteLine(result2);
        }
    }   
}