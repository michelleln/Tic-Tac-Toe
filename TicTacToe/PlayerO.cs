using System;
namespace TicTacToe
{
    public class PlayerO : Player
    {
        public PlayerO(Color color) : base(color)
        {

        }

        public override string ToString()
        {
            return "O";
        }
    }
}

