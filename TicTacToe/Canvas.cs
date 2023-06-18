using System;
namespace TicTacToe
{
	public class Canvas
	{
		//first we need a board
		public static void printBoard(Board b)
		{
			Console.WriteLine("3" + "    {0}    |    {1}    |   {2}  ", b.board[0, 0], b.board[0, 1], b.board[0, 2]);
			Console.WriteLine("   ------------------------- ");
			Console.WriteLine("2" + "    {0}    |    {1}    |   {2}  ", b.board[1, 0], b.board[1, 1], b.board[1, 2]);
            Console.WriteLine("   ------------------------- ");
            Console.WriteLine("1" + "    {0}    |    {1}    |   {2}  ", b.board[2, 0], b.board[2, 1], b.board[2, 2]);
            Console.WriteLine("   ------------------------- ");
			Console.WriteLine("       a      b      c       ");
        }

		public ChessPosition readPosition()
		{
            string s = Console.ReadLine();
            char row = s[0];            int column = int.Parse(s[1] + " "); //convert int to string
			return new ChessPosition(row, column);

        }
    }
}

