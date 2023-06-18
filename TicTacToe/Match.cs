using System;
namespace TicTacToe
{
	public class Match
	{
		//public so other classes can access the properties
		public Board board { get; set; }
		public Color currentPlayer;
		public int noOfTurnsLeft = 9;
		public bool matchIsComplete = false;

		public Match()
		{
			board = new Board(3, 3);
			currentPlayer = Color.Black;
		}

		public void changePlayer()
		{
			if (currentPlayer == Color.Black)
			{
				currentPlayer = Color.White;
			}
			else
			{
				currentPlayer = Color.Black;
			}
		}

		public Player whoIsPlaying()
		{
			if (currentPlayer == Color.Black)
			{
				return new PlayerO(Color.Black);
			}
			else
			{
				return new PlayerX(Color.Black);
			}
		}

		//heavy-lifting method; everything happens here; players play & switch turns
		public void makeMove(Position movePosition)
		{
            //identify which player is making the move, therefore include whoIsPlaying function, which returns X or O
            board.putPlayerAt(whoIsPlaying(), movePosition);
			//in a 3x3 matrix there are only 9 turns. If 0 turn left is reached, it's a tie
			noOfTurnsLeft--;
			changePlayer();
        }

		public void checkWinner()
		{
			//top row
			if(board.boardPos(0, 0) != null)
			{
				if (board.board[0, 0] == board.board[0, 1] && board.board[0, 1] == board.board[0, 2])
				{
					Console.WriteLine("Winner : " + board.board[0, 0]);
					Console.Read();
					matchIsComplete = true;
                }
			}

            //middle row
            if (board.boardPos(1, 0) != null)
            {
                if (board.board[1, 0] == board.board[1, 1] && board.board[1, 1] == board.board[1, 2])
				{
                    Console.WriteLine("Winner : " + board.board[1, 0]);
                    Console.Read();
                    matchIsComplete = true;
                }
            }

            //bottom row
            if (board.boardPos(0, 0) != null)
            {
                if (board.board[2, 0] == board.board[2, 1] && board.board[2, 1] == board.board[2, 2])
				{
                    Console.WriteLine("Winner : " + board.board[2, 0]);
                    Console.Read();
                    matchIsComplete = true;
                }
            }

            //left column
            if (board.boardPos(0, 0) != null)
            {
                if (board.board[0, 0] == board.board[1, 0] && board.board[1, 0] == board.board[2, 0])
				{
					Console.WriteLine("Winner : " + board.board[0, 0]);
                    Console.Read();
                    matchIsComplete = true;
                }
            }

            //middle column
            if (board.boardPos(0, 1) != null)
            {
                if (board.board[0, 1] == board.board[1, 1] && board.board[1, 1] == board.board[2, 1])
                {
                    Console.WriteLine("Winner : " + board.board[0, 1]);
                    Console.Read();
                    matchIsComplete = true;
                }
            }

            //bottom column
            if (board.boardPos(0, 2) != null)
            {
                if (board.board[0, 2] == board.board[1, 2] && board.board[1, 2] == board.board[2, 2])
                {
                    Console.WriteLine("Winner : " + board.board[0, 2]);
                    Console.Read();
                    matchIsComplete = true;
                }
            }

            //diagonal
            if (board.boardPos(0, 0) != null)
            {
                if (board.board[0, 0] == board.board[1, 1] && board.board[1, 1] == board.board[2, 2])
                {
                    Console.WriteLine("Winner : " + board.board[0, 0]);
                    Console.Read();
                    matchIsComplete = true;
                }
            }

            //reverse diagonal
            if (board.boardPos(0, 2) != null)
            {
                if (board.board[0, 2] == board.board[1, 1] && board.board[1, 1] == board.board[2, 0])
                {
                    Console.WriteLine("Winner : " + board.board[0, 2]);
                    Console.Read();
                    matchIsComplete = true;
                }
            }

            if (noOfTurnsLeft == 0)
            {
                Console.WriteLine("Tie");
                matchIsComplete = true;
            }
        }
	}
}

