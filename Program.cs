using MonopolyGame;
using System.Text.Json;

class Program
{
	static void Main()
	{
		Board board = new Board(40);
        board.InitializeBoard();

		IDice dice = new Dice();

		GameController gameController = new GameController(board, dice, GameStatus.Preparation);
		
		
	}	
}