namespace MonopolyGame;

public class CardCommunitySquare : SpecialSquare
{
    public string Name { get; private set; }

    public CardCommunitySquare(int id, string name): base(id, name)
    {
    }
    public override bool EffectSquare(IPlayer player, GameController game)
    {
        ICard card = game.DrawCardCommunity();
        card.ActionCard(player, game);
        return true;
    }
}
