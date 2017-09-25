using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {
	public class Behaviour : Component {
		public Behaviour() {
			Start();
			internalUpdate = () => { if (enabled) Update(); };
			internalUpdate += PersistantUpdate;
		}
		#region to be potentially overridden
		protected virtual void Start () { }
		protected virtual void Update() { }
		protected virtual void PersistantUpdate () { }
		#endregion
	}
}
