using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tac_Toe
{
    public class PlayerSwitcher
    {

        private char currentPlayer = 'X';
        public char GetPlayer()
        {
            return currentPlayer;
        }

        public void SwitchPlayer() //switching player based on current player.
        {
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
}
