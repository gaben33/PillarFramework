using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {

	public partial class Entity {

        private bool active = true;
        private Entity parent;
        private System system;
        private List<Entity> children = new List<Entity>();
        private List<Component> components = new List<Component>();

		public Entity(Entity parent) {
            this.parent = parent;
            System = parent.System;
        }
        
        public void AddChild(Entity child) {
            children.Add(child);
        }

        public void AddComponent(Component component){
            components.Add(component);
        }

        public bool Active {
            get { return active; }
            set { active = value;}
        }
        
        public System System {
            get { return system; }
            set { System = value; }
        }


	}
}
