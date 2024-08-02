namespace MonopolyGame;

public class PlayerData
{
	public PlayerPieces Piece;
	public decimal Balance {get; private set;}
	public List<Property> PropertyPlayer;
	public List<ICard> CardChanceSave;
	public ISquare playerPosition;

	public PlayerData(PlayerPieces piece, decimal money){
		Piece = piece;
		Balance = money;
		PropertyPlayer = new List<Property>();
		CardChanceSave = new List<ICard>();
	}
	public bool HaveAdvanceToGoCard(){
		// untuk mengetahuinya dari riwayat mendapatkan cardchance
		// periksa apakah pemain memiliki kartu "advance to go"
		return CardChanceSave.OfType<AdvanceToGo>().Any();
	}
	public bool HaveJailFreeCard()
	{
		return CardChanceSave.OfType<GetOutOfJailFree>().Any();
	}
	public void AddBalance(decimal cash)
	{
		Balance += cash;
	}
	public void DeductBalance(decimal cash)
	{
		Balance -= cash;
	}
	public bool GetBalance(IPlayer player)
	{
		Balance = Balance;
		return true;
	}
	public void SetPosition(ISquare newPosition){
		playerPosition = newPosition;
	}
}
