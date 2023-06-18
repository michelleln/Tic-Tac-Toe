using System;
namespace TicTacToe
{
	public class Player
	{
		public Position? position;
		public Color color;

		public Player(Color color)
		{
			//at the beginning of the game the position is null
			position = null;
			this.color = color;


		}

        
    }
}

