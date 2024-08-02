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
	public Action<IPlayer, ISquare, IDice> MovePlayer;
	public Action<IPlayer, Property> BuyProperty;
	public Action<IPlayer, Property> RentProperty;
	public Action<IPlayer, ICard> HandleCard;

	private List<ICard> _chanceCards;
	private List<ICard> _communityCards;
	public GameController(IBoard board, IDice dice, GameStatus gameStatus, int maxPlayer = 8)
	{
		_maxPlayer = maxPlayer;
		_board = board;
		_dice = dice;

	}
	public Board GetBoard()
	{
	    return (Board)_board;
	}
	public bool Start(){
		if(_gameStatus == GameStatus.Preparation){
			SetGameStatus(GameStatus.Play);
			return true;
		}
		return false;
	}
	public bool End(){
		return _gameStatus == GameStatus.End;
	}
	public void SetGameStatus(GameStatus status){
		return _gameStatus = status;
	}
	public GetGameStatus(){
		return _gameStatus;
	}
	public bool SetNumPlayer(int numPlayer){

	}
	public bool AddPlayer(IPlayer player){

	}
	public IPlayer GetPlayer(int idPlayer){

	}
	public PlayerData GetPlayerData(IPlayer player){
		return _player[player];
	} 
	public SetStartPlayerPosition(IBoard board, IPlayer player)
	{

	}
	public SetTurnPlayer(List<IPlayer>)
	{

	}
	public bool StartTurn(){

	}
	public int RollDice()
	{
		return _dice.Roll();
	}
	public bool MovePlayer(IPlayer player, ISquare idSquare, IDice rollResult)
	{

	}
	public bool EndTurn()
	{

	}
	public bool ChangeTurnPlayer()
	{

	}
	public bool HandleSquareEffect(IPlayer player, ISquare square)
	{

	}
	public bool HandleCardEffect(IPlayer player, ICard card)
	{

	}
	public bool HandleGoToJail(IPlayer player)
	{ 

	}
	public bool HandleGetOutJail(IPlayer player)
	{

	}
	public bool PayTax (IPlayer player, decimal amountOfMoney)
	{

	}
	public bool PayFee (IPlayer player, decimal amountOfMoney)
	{

	}
	public DeclareBankrupt()
	{

	}
	public CheckWinner()
	{

	}
	public ICard DrawCardChance(){

	}
	public ICard DrawCardCommunity(){

	}
}
