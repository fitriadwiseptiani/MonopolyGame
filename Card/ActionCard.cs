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
		// var currentPosition = player.SetPosition.Id;
		return true;
	}
}
public class AdvanceToLyon : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		var lyon = game.GetBoard().SquareBoard.First(s => s is Property && s.Name == "Lyon");
		game.MovePlayer(player, lyon, null); // Pindahkan pemain ke Illinois Avenue
		return true;
	}
}
public class AdvanceToLondon : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		var london = game.GetBoard().SquareBoard.First(s => s is Property && s.Name == "London");
		game.MovePlayer(player, london, null); // Pindahkan pemain ke kota Londonn
		return true;
	}
}
public class GoToVacation : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		var vacation = game.GetBoard().SquareBoard.First(FreeParkingSquare => true);
		game.MovePlayer(player, vacation, null); // Pindahkan pemain ke kota Londonn
		return true;
	}
}
public class AdvanceToMilan : ICardChance
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		var milan = game.GetBoard().SquareBoard.First(s => s is Property && s.Name == "Milan");
		game.MovePlayer(player, milan, null); // Pindahkan pemain ke kota Londonn
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
		game.GetPlayerData(player).AddBalance(50);
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
		game.GetPlayerData(player).AddBalance(150);
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
		game.GetPlayerData(player).DeductBalance(15);
		return true;
	}
}

// ICardCommunity
public class BankError : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).AddBalance(200);
		return true;
	}
}
public class DoctorsFee : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).DeductBalance(50);
		return true;
	}
}
public class IncomeTaxRefund : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).AddBalance(20);
		return true;
	}
}
public class PayHospital : ICardCommunity 
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).DeductBalance(100);
		return true;
	}
}
public class PaySchool : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).DeductBalance(50);
		return true;
	}
}
public class JailFree : ICardCommunity
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
public class GoToJailBro : ICardCommunity
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
public class FromSaleOfStock : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).AddBalance(50);
		return true;
	}
}
public class ChairmanOfTheBoard : ICardCommunity
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
public class LifeInsuranceMatures : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).AddBalance(100);
		return true;
	}
}
public class YouInherit : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).AddBalance(100);
		return true;
	}
}
public class GrandOperaNight: ICardCommunity
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
public class YourBirthday: ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		
		return true;
	}
}
public class HolidayFundMatures : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).AddBalance(100);
		return true;
	}
}
public class ConsultancyFee : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		game.GetPlayerData(player).AddBalance(25);
		return true;
	}
}
public class StreetRepairs : ICardCommunity
{
	public int Id {get;}
	public string Description {get;}
	public TypeCard typeCard { get; }

	public bool ActionCard(IPlayer player, GameController game)
	{
		return true;
	}
}