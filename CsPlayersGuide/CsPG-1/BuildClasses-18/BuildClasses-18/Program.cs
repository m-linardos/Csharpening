using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildClasses_18 {
	class Program {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		/// <param name="args">The arguments.</param>
		static void Main(string[] args) {
			// Creates hotPink color & then creates a ball using hotPink.
			Color hotPink = new Color(160, 160, 160);
			Ball myBall = new Ball(hotPink, 3);

			// Creates the ball & color in one statement;
			Ball yourBall = new Ball(new Color(255, 251, 98), 8);
			Ball kickBall = new Ball(new Color(220, 20, 60), 10);

			// Throw myBall a few times.
			yourBall.Throw();
			myBall.Throw();
			myBall.Throw();
			myBall.Throw();

		
	}
	}
}
