namespace MonopolyGame;

public class City : Property
{
	public List<City> listOfCities;
	public IPlayer Owner {get; set;}
	
	public override bool Buy(IPlayer player, GameController game)
	{
		return true;
	}
	public override bool Rent(IPlayer player, GameController game)
	{
		return true;
	}
	
	
}