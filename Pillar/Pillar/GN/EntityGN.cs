using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {
	public partial class Entity : IUpdatable {
		public void Step() {
			foreach (Component c in components) if(c.enabled) c.Step();
			foreach (Entity e in children) if(e.active) e.Step();
		}
	}
}