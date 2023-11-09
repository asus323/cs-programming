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
            var channelName = 1;
            var likeIt =false ;
            do{
               Console.WriteLine($"channel {channelName++}");
               Console.WriteLine($"do you love this channel ? (yes/no)");
               var answer = Console.ReadLine();
               likeIt = answer == "yes" ? true : false ;
            }while(!likeIt);
            Console.WriteLine($"Enjoy Wtching channel {channelName}");
            Console.WriteLine($"Good Bye");
            Console.Clear();
        }

    }

}
