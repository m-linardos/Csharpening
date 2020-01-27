using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign_18 {
	public class Color {

		private int red;
		private int green;
		private int blue;
		private int alpha; 


		public Color(int red, int green, int blue, int alpha) {
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = alpha;
		}
		public Color(int red, int green, int blue) {
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = 255; 
		}

		public int GetGreen() {
			return green;
		}				   
		public int GetRed() {
			return red;
		}

		public int GetBlue() {	
			return blue;	 			
		}

		public int GetAlpha() {	 
			return alpha;
		}

	   public void SetRed(int red) {
			this.red = red;
	   }

		public void SetGreen(int green) {
			this.green = green;
		}

		public void SetBlue(int blue) {
			this.blue = blue;
		}

		public void SetAlpha(int alpha) {
			this.alpha = alpha;
		}

		public int GetGrayscale(int red, int green, int blue){
			int grayscale = (red + blue + green) / 3;
			return grayscale;
		}

	}
}
