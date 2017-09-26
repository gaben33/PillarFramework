using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {

	public partial class Component {

        private System system;
        private Entity parent;

		public Component(Entity parent){ 
            system = parent.system;
            this.parent = parent;
        }
	}
}
