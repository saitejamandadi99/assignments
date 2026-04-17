using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tac_Toe
{
    public class TicTacToeFacade
    {
        private Board board = new Board();
        private CheckGame checkGame = new CheckGame();
        private PlayerSwitcher playerSwitcher = new PlayerSwitcher();

        public void StartGame()
        {
            while (true)
            {
                board.DisplayBoard();

                Console.WriteLine($"\nPlayer {playerSwitcher.GetPlayer()}, Enter row and Column (0-2)");
                int.TryParse(Console.ReadLine(), out int rowNo);
                int.TryParse(Console.ReadLine(), out int columnNo);
                if(!board.checkPoint(rowNo, columnNo, playerSwitcher.GetPlayer()))
                {
                    Console.WriteLine("Cell Already Taken");
                    continue;
                }
                char player = playerSwitcher.GetPlayer();
                if(checkGame.CheckWinner(board.GetBoard(), player))
                {
                    board.DisplayBoard();
                    Console.WriteLine($"Player {player} wins!");
                    break;
                }
                if (checkGame.CheckDraw(board.GetBoard()))
                {
                    board.DisplayBoard();
                    Console.WriteLine("It's a draw");
                }
                playerSwitcher.SwitchPlayer();
            }
        }

        public void ResetGame()
        {
            board.Reset();
            Console.WriteLine("Game Reset!!");
        }
    }
}
