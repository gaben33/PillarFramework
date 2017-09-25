using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {
	public class System : IUpdatable {
		public string name;
		public Entity root;

		public System(string name) {
			this.name = name;
			root = new Entity();
		}

		public void Step() {
			
		}
	}
}