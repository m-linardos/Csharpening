using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign_18 {
	class Ball {
		private int size;
		private Color color;
		private int thrownTimes;

		public Ball() {	}
		public Ball(int size, Color color, int thrownTimes) {
			this.size = size;
			this.color = color;
			this.thrownTimes = thrownTimes;
		}

		public void Pop(){
			size = 0;
		}

		public void Throw(int size){
			if(size != 0){
				size = size + 1;
			}

			public int GetThrownTimes() {
				return thrownTimes;
		}
		}
	}
}
