using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tac_Toe
{
    public class Board
    {
        private char[,] _board = new char[3,3];
        private int _row;
        private int _column;

        public Board()
        {
            Reset(); //resets game before the starting new game.
        }

        public bool checkPoint(int row, int col, char playerMark)
        {
            try
            {
                if (_board[row, col] != ' ')
                {
                    return false;
                }
                _board[row, col] = playerMark;
                return true;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return false; 
            }
        }

        public void DisplayBoard()
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{_board[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public char[,] GetBoard()
        {
            return _board;
        }
        public void Reset() //for reseting the game
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _board[i, j] = ' ';
                }
            }
        }
    }
}
