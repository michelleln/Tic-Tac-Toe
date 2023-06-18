using System;
namespace TicTacToe
{
	public class PlayerX : Player
	{
		public PlayerX(Color color) : base(color)
		{

		}

        public override string ToString()
        {
            return "X";
        }
    }
}

