namespace MonopolyGame;

public class Railroads
{
	public List<Railroads> listOfRailroads;

	public IPlayer Owner {get; set;}
	
	public Railroads(string name, decimal price, decimal rent)
	{
	}
	public virtual bool EffecSquare(IPlayer player)
	{
		return true;
	}
	public virtual bool Buy(IPlayer player)
	{
		return true;
	}
	public virtual bool Rent(IPlayer player, GameController game)
	{
		return true;
	}
}
