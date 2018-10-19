using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem {
	public class Inventory {
		public List<Item> inventory = new List<Item>();

		public string AddItem(string name, int charges) {
			Item item = new Item();
			item.id = name;
			item.charges = charges;
			inventory.Add(item);
			return $"{item.id} was added to your inventory\n";
		}

		public string RemoveItem(string name) {
			for (int i = 0; i < inventory.Count; i++) {
				if (inventory[i].id == name) {
					inventory.Remove(inventory[i]);
					return $"{name} was removed from your inventory. \n";
				}
			}

			return "Item was not found";
		}

		public string UseItem(string name) {
			for (int i = 0; i < inventory.Count; i++) {
				if (inventory[i].id == name) {
					inventory[i].Use();
					if (inventory[i].charges >= 1) {
						return $"You used: {name}. It has {inventory[i].charges} charges left";
					}
					else {
						inventory.Remove(inventory[i]);
						return $"You used {name}. It got destroyed";
					}
				}
			}

			return $"{name} was not found.";
		}

		public void ShowInventory() {
			if (inventory.Count < 1) {
				Console.WriteLine("No items in inventory");
			} else {
				for (int i = 0; i < inventory.Count; i++) {
					Console.WriteLine(inventory[i].id);
				}
			}
		}
	}
}
