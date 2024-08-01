using MonopolyGame;
using System.Text.Json;

// public class ListOfCity
// {
// 	// public int Id { get; set; }
// 	// public string Name{ get; set; }
// 	// public int Price{ get; set; }
// 	// public int RentPrice{get; set;}
// 	// public ListOfCity(int id, string name, int price, int rentPrice)
// 	// {
// 	// 	Id = id;
// 	// 	Name = name;
// 	// 	Price = price;
// 	// 	RentPrice = rentPrice;
// 	// }
// 	// public ListOfCity()
// 	// {
		
// 	// }
// }
class Program
{
	static void Main()
	{
		string result;
		
		using(StreamReader sr = new("./City.json")) 
		{
			result = sr.ReadToEnd();
		}
		List<ListOfCity> cityMonopoly = JsonSerializer.Deserialize<List<ListOfCity>>(result);
		
		string result2;
		
		using(StreamReader sr = new("./Utilities.json")) 
		{
			result = sr.ReadToEnd();
		}
		List<ListOfUtilities> utilitiesMonopoly = JsonSerializer.Deserialize<List<ListOfCity>>(result2);
		
		string result3;
		
		using(StreamReader sr = new("./Utilities.json")) 
		{
			result = sr.ReadToEnd();
		}
		List<ListOfRailroads> railroadsMonopoly = JsonSerializer.Deserialize<List<ListOfCity>>(result3);
		
		
	}	
}