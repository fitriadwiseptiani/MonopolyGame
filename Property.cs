namespace MonopolyGame;

public class Property
{
	public int Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
	public decimal RentPrice { get; private set; }
    public IPlayer Owner { get; private set; }

    public Property(int id, string name, decimal price, decimal rentPrice)
    {
        Id = id;
        Name = name;
        Price = price;
		RentPrice = rentPrice;
    }

    public virtual bool EffectSquare(IPlayer player, GameController game)
    {
        PlayerData playerData = game.GetPlayerData(player);

        // Jika properti dimiliki oleh orang lain, bayar sewa
        if (Owner != null && Owner != player)
        {
            PayRent(player, game);
            return true;
        }

        // Jika properti tidak dimiliki, tawarkan untuk dijual
        if (Owner == null && playerData.Balance >= Price)
        {
            BuyProperty(player, game);
            return true;
        }

        return false;
    }
	protected virtual void PayRent(IPlayer player, GameController game)
    {}

    protected void BuyProperty(IPlayer player, GameController game)
    {
        Owner = player;
        PlayerData playerData = game.GetPlayerData(player);
        playerData.DeductBalance(Price);
        game.BuyProperty?.Invoke(player, this);
    }
}
