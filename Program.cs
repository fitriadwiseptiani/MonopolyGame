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

// public class ListOfUtilities
// {
// 	public int Id { get; set; }
// 	public string Name{ get; set; }
// 	public int Price{ get; set; }
// 	public int RentPrice{get; set;}
// 	public ListOfUtilities(int id, string name, int price, int rentPrice)
// 	{
// 		Id = id;
// 		Name = name;
// 		Price = price;
// 		RentPrice = rentPrice;
// 	}
// 	public ListOfUtilities(){}
	
// }

// public class ListOfRailroads
// {
// 	public int Id { get; set; }
// 	public string Name{ get; set; }
// 	public int Price{ get; set; }
// 	public int RentPrice{get; set;}
// 	public ListOfRailroads(int id, string name, int price, int rentPrice)
// 	{
// 		Id = id;
// 		Name = name;
// 		Price = price;
// 		RentPrice = rentPrice;
// 	}
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
		List<City> cityMonopoly = JsonSerializer.Deserialize<List<City>>(result);
		
		string result2;
		
		using(StreamReader sr = new("./Utilities.json")) 
		{
			result2 = sr.ReadToEnd();
		}
		List<ListOfUtilities> utilitiesMonopoly = JsonSerializer.Deserialize<List<ListOfUtilities>>(result2);
		
		string result3;
		
		using(StreamReader sr = new("./Utilities.json")) 
		{
			result3 = sr.ReadToEnd();
		}
		List<ListOfRailroads> railroadsMonopoly = JsonSerializer.Deserialize<List<ListOfRailroads>>(result3);
		
		
	}	
}