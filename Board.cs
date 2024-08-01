namespace MonopolyGame;

public class Board : IBoard
{
	public int NumberOfSquare {get; private set;}
	public List<ISquare> SquareBoard { get; private set;}
	public List<ListOfCity> listOfCities;
	// List<listItem> myList = new List<listItem>();

	public Board(int numberOfSquare, int maxFields = 40){
		NumberOfSquare = numberOfSquare;
		SquareBoard = new List<ISquare>(maxFields);
	}
	public void InitializeBoard()
	{
		SquareBoard.Add(new GoSquare(1, "Go"));
		SquareBoard.Add(new );
		
		// SquareBoard.Add(new Salvador(2, "Salvador"));
		
	}
}
