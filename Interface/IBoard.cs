namespace MonopolyGame;

public interface IBoard
{
	public int NumberOfSquare {get;}
	public List<ISquare> SquareBoard { get; } 
	public void InitializeBoard();
}
