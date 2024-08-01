namespace MonopolyGame;

public class Dice : IDice
{
	public int NumberOfSides { get; private set; }
	public int[] SideValues { get; private set; }

	public Dice(int numberOfSides)
	{
		NumberOfSides = numberOfSides;
		SideValues = Enumerable.Range(1, numberOfSides).ToArray();
			
	}
	public int Roll(){
		Random random = new Random();
		return random.Next(1, NumberOfSides + 1);
	}
}
