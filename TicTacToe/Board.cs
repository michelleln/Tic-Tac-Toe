using System;
namespace TicTacToe
{
	public class Board
	{
		public int rows { get; set; }
		public int columns { get; set; }
		public string[,] board;

		public Board(int rows, int columns)
		{
			this.rows = rows;
			this.columns = columns;
			board = new string[rows, columns];
		}

		//return a specific position on the board
		public string boardPos(Position pos)
		{
			insideBoard(pos);
			return board[pos.row, pos.column];
		}

		//return all the position on the board
		public string boardPos(int rows, int columns)
		{
			return board[rows, columns];
		}

		public bool positionIsOccupied(Position pos)
		{
			//before checking if the position is occupied, first check if it's valid
			//if this position is different from null, it means it's occupied
			return boardPos(pos) != null;
		}

		public void putPlayerAt(Player player, Position pos)
		{
			//if the position chosen is occupied, the player can't put their sign 
			if (positionIsOccupied(pos))
			{
				throw new BoardException("The other player is already in this position");
			}

			//else, access the board position the player is trying to put in
			board[pos.row, pos.column] = player.ToString();
			player.position = pos;
		}

		public bool isOutOfBoard(Position pos)
		{
			if (pos.row < 0 || pos.row >= rows || pos.column < 0 || pos.column >= columns)
			{
				return false;
			}
			return true;
		}

		public void insideBoard(Position pos)
		{
			if (!isOutOfBoard(pos))
			{
				throw new BoardException("Position is out of Board");
			}
		}
	}
}

