using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildClasses_18 {
	class Color {
		private int red;
		private int green;
		private int blue;
		private int alpha;

		public Program(int red, int green, int blue, int alpha) {
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = alpha;

		}

		public Program(int red, int green, int blue) {
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = 255;

		}

		//public  MyProperty {
		//	get { return green; }
		//	set { green = value; }
		//}


		//public int MyProperty {
		//	get { return red; }
		//	set { red = value; }
		//}
	}
}
