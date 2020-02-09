using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildClasses_18 {
	/// <summary>
	/// This represents a ball described by color, size & number of times thrown. 
	/// </summary>
	class Ball {
	//
		private Color color;
		private float circumfrance;
		private int passes = 0;


		/// <summary>
		/// Popped the ball.
		/// </summary>
		public void Popped() {
			this.circumfrance = 0;
		}

		/// <summary>
		/// Throws the ball, adding it to the number of passes.
		/// </summary>
		/// <param name="passes">The passes.</param>
		public void Throw (int passes) {
			if(circumfrance != 0) {
				this.passes = passes + 1;
			}
		}

		/// <summary>
		/// Gets the passes.
		/// </summary>
		/// <returns>passes</returns>
		public int GetPasses() {
			return passes;
		}

		public Ball(Color color, float circumfrance, int passes ) {
			this.color = color;
			this.circumfrance = circumfrance;
			this.passes = passes;
				
		}

		public Ball(Color color, float circumfrance) {
			this.color = color;
			this.circumfrance = circumfrance;
			this.passes = 0;
		}

		public Ball() {

		}

	}
}
