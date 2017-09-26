using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {
	public abstract class Behaviour : Component {
		public Behaviour(Entity entity) : base(entity) {
			Start();
			internalUpdate = () => { if (!system.paused) Update(); };
			internalUpdate += PersistantUpdate;
		}
		#region to be potentially overridden
		protected virtual void Start () { }
		protected virtual void Update() { }
		protected virtual void PersistantUpdate () { }
		#endregion
	}
}