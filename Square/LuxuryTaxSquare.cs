namespace MonopolyGame;

public class LuxuryTaxSquare : SpecialSquare
{
    public string Name { get; private set; }

    public LuxuryTaxSquare(int id, string name): base(id, name)
    {
    }
    public virtual bool EffectSquare(IPlayer player, GameController game){
        // nilai untuk luxurytax = 75
        PlayerData playerData = game.GetPlayerData(player);
        playerData.DeductBalance(75);   
        return true;
    }
}
