namespace MonopolyGame;

public interface ISquare
{
    public int Id { get; }
    public string Name { get; }

    public bool EffectSquare(IPlayer player, GameController game);
}
