namespace MonopolyGame;

// ICardChance
public class AdvanceToGo : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		var goSquare = game.GetBoard().SquareBoard.First(s => s is GoSquare); // Pindahkan pemain ke Go
        game.MovePlayer(player, goSquare, null); // Pindahkan pemain ke posisi Go
        game.GetPlayerData(player).AddBalance(200);
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
		var currentPosition = player.SetPosition.Id;
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
		var illinoisAvenue = game.GetBoard().SquareBoard.First(s => s is Property && s.Name == "Illinois Avenue");
        game.MovePlayer(player, illinoisAvenue, null); // Pindahkan pemain ke Illinois Avenue
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
		game.GetPlayerData(player).AddBalance(150);
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
		var amount = 50;
		
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