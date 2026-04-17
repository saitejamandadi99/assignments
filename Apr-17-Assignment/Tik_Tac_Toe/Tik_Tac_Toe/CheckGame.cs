using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tac_Toe
{
    public class CheckGame
    {
        public bool CheckWinner(char[,] board , char playerMark)
        {
            for(int i = 0; i < 3; i++)
            {
                if ( (board[i,0] == playerMark && board[i,1] == playerMark && board[i,2] == playerMark) || (board[0,i] == playerMark && board[1,i] == playerMark && board[2,i] == playerMark) ){
                    return true;
                } //checks 1. all columns of row are equal to mark || 2. all rows of the column equal to mark
            }
            if ((board[0, 0] == playerMark && board[1, 1] == playerMark && board[2, 2] == playerMark) || (board[0, 2] == playerMark && board[1, 1] == playerMark && board[2, 0] == playerMark))
            {
                return true;
            }//checks both the diagonals.
            return false;
        }

        public bool CheckDraw(char[,] board)
        {
            foreach(var cell in board)
            {
                if(cell == ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }

   
}
