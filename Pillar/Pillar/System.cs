using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {
	public class System : IUpdatable {
		public string name { get; private set; }
		public Entity root;
		public bool paused = false;

		public static System current;//last created system

		public System(string name) {
			this.name = name;
			root = new Entity(null);
			current = this;
		}

		public void Step() {
			root.Step();
		}
	}
}