using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //boards take in 2 arguments, rows and columns
            Match match = new Match();
            Canvas canvas = new Canvas();

            try
            {
                while (!match.matchIsComplete)
                {
                    
                    try 
                    {
                        match.checkWinner();
                        Canvas.printBoard(match.board);
                        Console.WriteLine(match.noOfTurnsLeft);
                        Console.WriteLine("Waiting for player {0}", match.whoIsPlaying());
                        Position pos = canvas.readPosition().convertToChessPosition();
                        match.makeMove(pos);
                        

                        Console.Clear();

                    }

                    catch (BoardException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                        
                    }

                }

            }
            catch(BoardException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            Console.Clear();

        }
    }
}
