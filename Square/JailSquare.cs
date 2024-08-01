namespace MonopolyGame;

public class JailSquare : SpecialSquare
{
    public JailSquare(int id, string name) : base(id, name) { }

    public override bool EffectSquare(IPlayer player, GameController game)
    {
        // Player goes to jail
        game.HandleGoToJail(player);
        return true;
    }
}