using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {

	public partial class Component {

        protected System system { get; private set; }
        protected Entity entity { get; private set; }

		public Component(Entity parent) {
			if (parent == null) system = System.current;
			else system = parent.system;
            this.entity = parent;
        }
	}
}
