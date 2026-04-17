namespace Tik_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tictactoe = new TicTacToeFacade();
            while (true)
            {
                tictactoe.StartGame();
                Console.WriteLine("Want to play game again (y/n)");
                string choice = Console.ReadLine();
                if(choice != "y")
                {
                    Console.WriteLine("Thank you ");
                    break;
                }
                tictactoe.ResetGame();
            }
        }
    }
}
