using System;
using System.Collections.Generic;
using System.Linq;

namespace MonopolyGame
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("########################################################################################");
			Console.WriteLine("|											|");
			Console.WriteLine("|					Monopoly Game					|");
			Console.WriteLine("|											|");	
			Console.WriteLine("########################################################################################");
			// 1. Instansiasi komponen kunci
			IBoard board = new Board(40); // Asumsi Board diimplementasikan
			IDice dice = new Dice(6); // Dadu dengan 6 sisi
			GameStatus gameStatus = GameStatus.Preparation; // Status awal permainan
			GameController gameController = new GameController(board, dice, gameStatus);

			// 2. Langganan ke event untuk hasil lemparan dadu
			gameController.OnDiceRolled += HandleDiceRolled;

			// 3. Menampilkan status awal permainan
			DisplayInitialGameStatus(gameController);

			// // 4. Menambahkan pemain
			// AddPlayers(gameController);

			// 5. Memulai permainan
			if (gameController.StartTurn())
			{
				Console.WriteLine("Turn dimulai.");
			}
			else
			{
				Console.WriteLine("Gagal memulai turn.");
			}

			// Tambahkan logika tambahan untuk melanjutkan permainan...

			// Simulasi turn
			SimulateGameTurns(gameController);
		}

		private static void DisplayInitialGameStatus(GameController gameController)
		{
			Console.WriteLine("Status permainan:");
			// Console.WriteLine($"Jumlah pemain: {gameController.TurnToPlay.Count}");
			// Tampilkan informasi lain sesuai kebutuhan, misalnya status board
		}

		private static void AddPlayers(GameController gameController)
		{
		    // Asumsi IPlayer dan PlayerData sudah diimplementasikan
			IPlayer player1 = new Player("Pemain 1");
		    IPlayer player2 = new Player("Pemain 2");

		    if (gameController.SetNumPlayer(2))
		    {
		        gameController.AddPlayer(player1);
		        gameController.AddPlayer(player2);
		        Console.WriteLine("Pemain ditambahkan.");
		    }
		    else
		    {
		        Console.WriteLine("Tidak dapat menambahkan pemain.");
		    }
		}

		private static void SimulateGameTurns(GameController gameController)
		{
			// Simulasi beberapa turn
			for (int i = 0; i < 3; i++)
			{
				if (gameController.StartTurn())
				{
					Console.WriteLine($"Simulasi turn {i + 1}...");
					// Tambahkan logika untuk mengelola giliran pemain, seperti gerakan, pembelian, dll.
				}
				gameController.EndTurn();
			}
		}

		private static void HandleDiceRolled(int firstRoll, int secondRoll, int totalRoll)
		{
			// Tampilkan hasil lemparan dadu
			Console.WriteLine($"Hasil dadu pertama: {firstRoll}");
			Console.WriteLine($"Hasil dadu kedua: {secondRoll}");
			Console.WriteLine($"Jumlah total: {totalRoll}");
		}
	}
}
