namespace MonopolyGame;

public interface ICard
{
    public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game);
}
