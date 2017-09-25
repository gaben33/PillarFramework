using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {

	public partial class Entity {

        public bool active = true;
        public int id;
        private Entity parent;
        private System system;
        private List<Entity> children = new List<Entity>();
        private List<Component> components = new List<Component>();

		public Entity(Entity parent) {
            this.parent = parent;
        }

        public List<Entity> GetChildren() {
            return children;
        }
        
        public void AddChild(Entity child) {
            children.Add(child);
        }

        public void HasChild(Entity otherChild) {
            foreach(Entity child in children){
                if(otherChild.Equals(child)) return true;
            }
            return false;
        }

        public void AddComponent(Component component) {
            components.Add(component);
        }

        public bool equals(Entity other){
            if(other.id == id) return true;
            return false;
        }


	}
}
