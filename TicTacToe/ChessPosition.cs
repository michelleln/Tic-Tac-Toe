using System;
namespace TicTacToe
{
	public class ChessPosition
	{
		char column { get; set; }
		int row { get; set; }

		public ChessPosition(char column, int row)
		{
			this.column = column;
			this.row = row;
		}

		public Position convertToChessPosition()
		{
			return new Position(3 - row, column - 'a');
		}
	}
}

