namespace MonopolyGame;

public class CardChanceSquare : SpecialSquare
{
    public string Name { get; private set; }

    public CardChanceSquare(int id, string name): base(id, name)
    {
    }
    public override bool EffectSquare(IPlayer player, GameController game)
    {
        ICard card = game.DrawCardChance();
        card.ActionCard(player, game);
        return true;
    }
}
