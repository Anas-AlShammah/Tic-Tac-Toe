namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {

            StartGame();

        }
        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

            var win = CreatePlayer();

            Console.WriteLine(win.Name);




        }
        static Player CreatePlayer()
        {
            //Player player1 = new Player();

            var player1 = new Player();
            player1.Matker = "X";
            player1.IsTurn = true;
            var player2 = new Player();
            player2.Matker = "O";
            player2.IsTurn = false;
            Console.WriteLine("name of Player 1: ");
            string name1 = Console.ReadLine();
            player1.Name = name1;
            Console.WriteLine("name of Player 2: ");
            string name2 = Console.ReadLine();
            player2.Name = name2;
            Player play = player1;
            bool wantPlay = true;
            int numWin1 = 0;
            int numWin2 = 0;
            while (wantPlay)
            {
                var game = new Game(player1, player2);
                play = game.Play();
                var win1 = game.Winner;

                if (win1.Matker == "X")
                {
                    numWin1++;
                }
                else if (win1.Matker == "O")
                {
                    numWin2++;
                }
                Console.WriteLine(win1.Name + " win this Game");
                Console.WriteLine(player1.Name + " : " + numWin1);
                Console.WriteLine(player2.Name + " : " + numWin2);
                Console.WriteLine("You want to paly again?y//n");
                string ans = Console.ReadLine();
                if (ans == "n")
                {
                    wantPlay = false;
                }

            }
            if (numWin1 > numWin2)
            {
                return player1;

            }
            else if (numWin2 > numWin1)
            {
                return player2;
            }
            else
            {
                var drwa = new Player();
                drwa.Name = "no one win";
                return drwa;
            }





        }

    }
}