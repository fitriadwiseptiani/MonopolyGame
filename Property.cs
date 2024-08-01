namespace MonopolyGame;

public class Property
{
	public string Name {get; private set;}
	public decimal Price {get; private set;}
	public decimal RentPrice {get; private set;}
	// public IPlayer Owner {get; set;}
	
	// public Property(string name, decimal price, decimal rent)
	// {
	// }
	
	public virtual bool Buy(IPlayer player, GameController game)
	{
		return true;
	}
	public virtual bool Rent(IPlayer player, GameController game)
	
	{
		return true;
	}
}
