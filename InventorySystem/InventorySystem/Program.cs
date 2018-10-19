using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.CommandLineUtils;

namespace InventorySystem {
	class Program {
		static void Main(string[] args) {
			Inventory inventory = new Inventory();
			string command;
			string item;
			bool quit = false;
			while (!quit) {
				command = Console.ReadLine();

				switch (command) {
					case "add item":
						string charges;
						Console.WriteLine($"What would you like to add?");
						item = Console.ReadLine();
						Console.WriteLine($"How many charges can it hold?");
						charges = Console.ReadLine();

						if (!int.TryParse(charges, out var i)) { 
							Console.WriteLine("Invalid amount");
							break;
						}

						Console.WriteLine(inventory.AddItem(item, i));
						break;

					case "remove item":
						Console.WriteLine($"What would you like to remove?");
						item = Console.ReadLine();
						Console.WriteLine(inventory.RemoveItem(item));
						break;

					case "use item":
						Console.WriteLine("What would you like to use?");
						item = Console.ReadLine();
						Console.WriteLine(inventory.UseItem(item));
						break;

					case "show inventory":
						inventory.ShowInventory();
						break;

					case "bye now":
						quit = true;
						break;

					case "help":
						Console.WriteLine($"You can choose the following commands: \n add item \n remove item \n use item \n show inventory \n bye now \n");
						break;
				}
			}
		}
	}
}
