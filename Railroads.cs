namespace MonopolyGame;

public class Railroads : Property, ISquare
{
	public decimal RentPrice { get; private set; }

    public Railroads(int id, string name, decimal price, decimal rentPrice)
        : base(id, name, price, rentPrice)
    {
        RentPrice = rentPrice;
    }

    public override bool EffectSquare(IPlayer player, GameController game)
    {
        PlayerData playerData = game.GetPlayerData(player);

        // Jika properti dimiliki oleh orang lain, maka bayar sewa
        if (Owner != null && Owner != player)
        {
            PayRent(player, game);
            return true;
        }

        // Jika properti tidak dimiliki, maka bisa ddibeli pemain
        if (Owner == null && playerData.Balance >= Price)
        {
            BuyProperty(player, game);
            return true;
        }

        return false;
    }

    protected override void PayRent(IPlayer player, GameController game)
    {
        PlayerData playerData = game.GetPlayerData(player);
        playerData.DeductBalance(RentPrice);
        PlayerData ownerData = game.GetPlayerData(Owner);
        ownerData.AddBalance(RentPrice);
    }
}
