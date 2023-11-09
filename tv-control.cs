using System;

namespace Desktop
{
    class tvcontrol
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //* TV control
            //! show the channel name
            //!ask did you like it?
            //! if you liked it contenue the app
            //! if you didnt like it breaks the loop
            var channelName = 0;
            var likeIt =false ;
            do{
               Console.WriteLine($"channel {++channelName}");
               Console.WriteLine($"do you love this channel ? (yes/no)");
               Console.WriteLine("1) Yes");
               Console.WriteLine("2) No");
               var answer = Console.ReadLine();
               likeIt = answer == "1" ? true : false ;
            }while(!likeIt);
            Console.Clear();
            Console.WriteLine($"Enjoy Wtching channel {channelName}");
            Console.WriteLine($"Good Bye");
        }

    }

}