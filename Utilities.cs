namespace MonopolyGame;

public class Utilities : Property
{
	public List<Utilities> listOfUtilities;
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
