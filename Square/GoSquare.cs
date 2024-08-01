namespace MonopolyGame;

public class GoSquare : SpecialSquare
{
    public string Name { get; private set; }

    public GoSquare(int id, string name): base(id, name)
    {
    }
    public override bool EffectSquare(IPlayer player, GameController game){
        // mengambil data pada player data dan menambahkan balance sebesar 200 bila melewati GO
        PlayerData playerData= game.GetPlayerData(player);
        playerData.AddBalance(200);
        return true;
    }
}
