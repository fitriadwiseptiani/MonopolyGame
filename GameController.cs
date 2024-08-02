namespace MonopolyGame;

public class GameController
{
	private readonly int _maxPlayer;
	private int _numPlayer;
	private IBoard _board;
	private IDice _dice;
	private GameStatus _gameStatus;
	private Dictionary<IPlayer, PlayerData> _player;
	public List<IPlayer> turnToPlay;
	// public Action<IPlayer, ISquare, IDice> MovePlayer;
	public Action<IPlayer, Property> BuyProperty;
	public Action<IPlayer, Property> RentProperty;
	public Action<IPlayer, ICard> HandleCard;
	public event Action<int, int, int> OnDiceRolled;

	private List<ICardChance> _chanceCards;
	private List<ICardCommunity> _communityCards;
	public GameController(IBoard board, IDice dice, GameStatus gameStatus, int maxPlayer = 8)
	{
		_maxPlayer = maxPlayer;
		_board = board;
		_dice = dice;
		_gameStatus = gameStatus;
		_player = new Dictionary<IPlayer, PlayerData>();
		turnToPlay = new List<IPlayer>();
		_chanceCards = new List<ICardChance>();
		_communityCards = new List<ICardCommunity>();
		

	}
	public Board GetBoard()
	{
		return (Board)_board;
	}
	public bool Start(){
		if (_gameStatus == GameStatus.Play)
            {
                // Lempar dadu dan dapatkan hasilnya
                int firstRoll, secondRoll;
                int totalRoll = _dice.RollTwoDice(out firstRoll, out secondRoll);

                // Panggil event dengan hasil lemparan dadu
                OnDiceRolled?.Invoke(firstRoll, secondRoll, totalRoll);

                return true;
            }
            return false;
	}
	public bool End(){
		return _gameStatus == GameStatus.End;
	}
	public void SetGameStatus(GameStatus status){
		if(status == GameStatus.Preparation)
		{
			GetBoard();
			
		}
		else if(status == GameStatus.Play)
		{
			StartTurn();
		}
		else
		{
			status = GameStatus.End;
			End();
		}
	}
	// public GetGameStatus(){
		
	// }
	public bool SetNumPlayer(int numPlayer){
		if(_numPlayer <= _maxPlayer)
		{
			_numPlayer = numPlayer;
			return true;
		}
		return false;
		
	}
	public bool AddPlayer(IPlayer player){
		if(!_player.ContainsKey(player) && _player.Count <= _maxPlayer)
		{
			_player[player] = new PlayerData(PlayerPieces.Battleship, 5000);
			turnToPlay.Add(player);
			return true;
		}
		return false;
	}
	public IPlayer GetPlayer(int idPlayer){
		return turnToPlay.FirstOrDefault(p => p.Id == idPlayer);
	}
	public PlayerData GetPlayerData(IPlayer player){
		return _player[player];
	} 
	public bool SetStartPlayerPosition(IBoard board, IPlayer player)
	{
		return true;
	}
	public void SetTurnPlayer(List<IPlayer> players)
	{
		turnToPlay = players;
		
	}
	public bool StartTurn(){
		if(_gameStatus == GameStatus.Play)
		{
			Console.WriteLine("Roll the Dice");
			return true;
		}
		return false;
	}
	public int RollDice()
	{
		return _dice.Roll();
	}
	public bool MovePlayer(IPlayer player, ISquare idSquare, IDice rollResult)
	{
		// var positionPlayer = new PlayerData();
		return true;
	}
	public bool EndTurn()
	{
		if (_gameStatus == GameStatus.Play)
		{
			Console.WriteLine("Turn End");
			return true;
		}
		return false;
	}
	public bool ChangeTurnPlayer()
	{
		return true;
	}
	public bool HandleSquareEffect(IPlayer player, ISquare square)
	{
		return square.EffectSquare(player, this);
	}
	public bool HandleCardEffect(IPlayer player, ICard card)
	{
		return card.ActionCard(player, this);
	}
	public bool HandleGoToJail(IPlayer player)
	{ 
		// GetPlayerData(player).SetPosition(ISquare newPosition) => 
		return true;
	}
	public bool HandleGetOutJail(IPlayer player)
	{
		return true;
	}
	public bool PayTax (IPlayer player, decimal amountOfMoney)
	{
		if (player == player)
		{
			GetPlayerData(player).DeductBalance(15);
			return true;
		}
		return false;
	}
	// public bool PayFee (IPlayer player, decimal amountOfMoney)
	// {

	// }
	public bool DeclareBankrupt(IPlayer player)
	{
		if (GetPlayerData(player).Balance == 0)
		{
			Console.WriteLine($"{player.Name} telah bankrupt");
			return true;
		}
		return false;
		
	}
	// public IPlayer void CheckWinner()
	// {
	// 	return player;
	// }
	public ICard DrawCardChance(){
		Random rdm = new Random();
		int index = rdm.Next(_chanceCards.Count);
		ICard card= _chanceCards[index];
		_chanceCards.RemoveAt(index);
		return card;
	}
	public ICard DrawCardCommunity()
	{
		Random rdm = new Random();
		int index = rdm.Next(_communityCards.Count);
		ICard card= _communityCards[index];
		_communityCards.RemoveAt(index);
		return card;
	}
}
