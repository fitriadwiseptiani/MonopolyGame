namespace MonopolyGame;

public class Utilities
{
	public int Id {get; private set;}
	public string Name {get; private set;}
	public decimal Price {get; private set;}
	public decimal RentPrice {get; private set;}
	public IPlayer Owner {get; set;}
	
	public Utilities(string name, decimal price, decimal rent)
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
