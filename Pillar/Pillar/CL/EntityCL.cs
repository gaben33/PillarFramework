using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {

    private bool active = true;
    private Entity parent;
    private System system;
    private List<Entity> children = new List<children>();
    private List<Component> components = new List<Component>();


	public partial class Entity {

		public Entity(Entity parent) {
            this.parent = parent;
            System = parent.System;
        }

        public void PersistentUpdate(){
            foreach(Component component in components) {
                component.PersistentUpdate();
            }
            foreach(Entity child in children) {
                child.Update();
            }
        }

        public void Update(){
            foreach(Component component in components) {
                component.Update();
            }
            foreach(Entity child in children) {
                child.Update();
            }
        }
        
        public void AddChild(Entity child) {
            
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
