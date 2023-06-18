using System;
namespace TicTacToe
{
	public class BoardException : ApplicationException
	{
		public BoardException(string message) : base(message)
		{
		}
	}
}

