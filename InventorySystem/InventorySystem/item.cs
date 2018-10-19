using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem {
	public class Item {
		public string id;
		public int charges = 0;

		public void Use() {
			charges -= 1;
		}
	}
}
