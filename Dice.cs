namespace MonopolyGame;

public class Dice : IDice
{
	private static Random _random = new Random();
	public int NumberOfSides { get; private set; }
	public int[] SideValues { get; private set; }

	public Dice(int numberOfSides)
	{
		NumberOfSides = numberOfSides;
		SideValues = Enumerable.Range(1, numberOfSides).ToArray();

	}
	public int Roll()
	{
		return _random.Next(1, NumberOfSides + 1);
	}

	public int RollTwoDice(out int firstRoll, out int secondRoll)
	{
		firstRoll = Roll();
		secondRoll = Roll();
		return firstRoll + secondRoll;
	}
}
