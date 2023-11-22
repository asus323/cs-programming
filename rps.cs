using System;

namespace Desktop
{
    class RPS
    {
        static void Main(string[] args)
        { 
            
            bool playAgain = true;
            do{
            showHelps();
            chooseSwitch();
            Console.WriteLine("Do you want to play again? Y/N");
            var answer= Console.ReadLine().ToUpper();
            playAgain = answer =="Y" ? true :false;
            }while(playAgain);
        }
        static void showHelps(){
            Console.WriteLine("Please choose your option");
            Console.WriteLine("1)Rock");
            Console.WriteLine("2)Paper");
            Console.WriteLine("3)Scissors");
        }     
        static void chooseSwitch(){
            string[] conditions = {"Rock","Paper", "Scissors"};
            Random random = new Random();
            var computerRandomName = random.Next(conditions.Length);
            string computerChoose =conditions[computerRandomName];
            var choosedByMe= Console.ReadLine();
             if(choosedByMe == computerChoose ){
                Console.WriteLine("DRAW!!");
            }else{
                switch(choosedByMe){
                    case "1":
                        Console.WriteLine("You choosed Rock");
                        Console.WriteLine($"computer choosed {computerChoose}");
                        if(computerChoose == "Paper"){
                            Console.WriteLine("You Lost");
                        }else{
                            Console.WriteLine("You Win");
                        }
                        break;
                    case "2":
                         Console.WriteLine("You choosed Paper");
                        Console.WriteLine($"computer choosed {computerChoose}");
                               if(computerChoose == "Scissors"){
                            Console.WriteLine("You Lost");
                        }else{
                            Console.WriteLine("You Win");
                        }
                        break;
                    case "3" :
                     Console.WriteLine("You choosed Scissors");
                     Console.WriteLine($"computer choosed {computerChoose}");
                    if(computerChoose == "Rock") {
                            Console.WriteLine("You Lost");
                        }else{
                            Console.WriteLine("You Win");
                        }
                        break;
                    default:
                        badCommands();
                        break;
                }
            }
            
        }
        static void badCommands(){
            Console.WriteLine("You entered invalid input");
        }
    }   
}