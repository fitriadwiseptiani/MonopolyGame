using MonopolyGame;
using System.Text.Json;

class Program
{
	static void Main()
	{
		Board board = new Board(40);
		board.InitializeBoard();

		Dice dice = new Dice(6);
		Console.WriteLine(dice.RollTwoDice(out int firstRoll, out int secondRoll));

		GameController gameController = new GameController(board, dice, GameStatus.Preparation);
		
		
	}	
}