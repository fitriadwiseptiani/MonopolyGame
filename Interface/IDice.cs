namespace MonopolyGame;

public interface IDice
{
	private static Random _random = new Random();
	public int NumberOfSides { get;}
	public int[] SideValues { get;}
	// private int sideValues[] { get;}

	public int Roll();
	public int RollTwoDice(out int firstRoll, out int secondRoll);
}
