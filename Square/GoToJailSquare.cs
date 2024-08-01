namespace MonopolyGame;

public class GoToJailSquare : SpecialSquare
{
    public GoToJailSquare(int id, string name) : base(id, name) { }

    public override bool EffectSquare(IPlayer player, GameController game)
    {
        // Player goes to jail
        game.HandleGoToJail(player);
        return true;
    }
}