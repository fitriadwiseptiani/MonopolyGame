namespace MonopolyGame;

public class CardCommunity : ICard
{
	public int Id {get; private set;}
	public string Description {get; private set;}
	public TypeCard typeCard { get; private set;}
	public CommunityCard CommunityCard { get; }
	
	public CardCommunity(int id, string description, CommunityCard communityCard)
	{
		Id = id;
		Description = description;
		CommunityCard = communityCard;
	}
	public bool ActionCard(IPlayer player, GameController game)
	{
		PlayerData playerData= game.GetPlayerData(player);
		switch(CommunityCard)
		{
			case CommunityCard.BankError:
			// Collect 200 from bank
			playerData.AddBalance(200);
				break;

			case CommunityCard.DoctorsFee:
			// pay 50 to bank
			playerData.DeductBalance(50);
			break;

			case CommunityCard.IncomeTaxRefund:
			// collect 20
			playerData.AddBalance(20);
			break;

			case CommunityCard.PayHospital:
			playerData.DeductBalance(100);
			break;

			case CommunityCard.PaySchool:
			playerData.DeductBalance(50);
			break;

			case CommunityCard.JailFree:
			game.HandleGetOutJail(player);
			break;

			case CommunityCard.GoToJail:
			game.HandleGoToJail(player);
			break;

			case CommunityCard.FromSaleOfStock:
			playerData.AddBalance(50);
			break;

			case CommunityCard.ChairmanOfTheBoard:

			case CommunityCard.LifeInsuranceMatures:
			playerData.AddBalance(100);
			break;

			case CommunityCard.YouInherit:
			playerData.AddBalance(100);

			case CommunityCard.GrandOperaNight:
			
			case CommunityCard.YourBirthday:

			case CommunityCard.HolidayFundMatures:
			playerData.AddBalance(100);
			break;

			case CommunityCard.ConsultancyFee:

			case CommunityCard.StreetRepairs:

			// buat sebagai final case label
			default:
				return false;
		}
	}
}
