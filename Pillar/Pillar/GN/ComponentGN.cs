﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillar {
	public partial class Component : IUpdatable {
		public bool enabled = true;
		protected Action internalUpdate;
		public void Step() => internalUpdate?.Invoke();
	}
}
