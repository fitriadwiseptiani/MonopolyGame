namespace MonopolyGame;

// ICardChance
public class AdvanceToGo : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		// game.MovePlayer(player, game.board, null);
		playerData.AddBalance(200);
		return true;
	}
}
public class GoToJail : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		game.HandleGoToJail(player);
		return true;
	}
}
public class GetOutOfJailFree : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		game.HandleGetOutJail(player);
		return true;
	}
}
public class PayPoorTax : ICardChance 
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		game.PayTax(player, 15);
		playerData.DeductBalance(15);
		return true;
	}
}
public class GoBackThreeSquare : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		// int back = game.board[]-3;
		// game.MovePlayer(player, game.Board[], null)
		return true;
	}
}
public class AdvanceToIllinoisAvenue : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		// game.MovePlayer(player, game.);
		return true;
	}
}
public class AdvanceToStCharlesPlace : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		return true;
	}
}
public class TakeARideOnTheReadingPlace : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		return true;
	}
}
public class AdvanceToBroadwalk : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		return true;
	}
}
public class YourBuildingLoanMatures : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		playerData.AddBalance(150);
		return true;
	}
}
public class BankPaysYouDividend : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		playerData.AddBalance(50);
		return true;
	}
}
public class PayEachPlayer: ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		return true;
	}
}
public class BuildingAndLoanAssociation: ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		playerData.AddBalance(150);
		return true;
	}
}
public class GeneralRepairs : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		return true;
	}
}
public class SpeedingFine : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		playerData.DeductBalance(15);
		return true;
	}
}