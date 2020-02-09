using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuildClasses_18 {
/// <summary>
/// Describes color composition values of red, blue, green.  Alpha value defines level of transparency. 
/// </summary>
	class Color {
		private int red;
		private int green;
		private int blue;
		private int alpha;

		/// <summary>
		/// Creates a color with values of red, green & blue and alpha value of transparency.
		/// </summary>
		/// <param name="red"></param>
		/// <param name="green"></param>
		/// <param name="blue"></param>
		/// <param name="alpha"></param>
		public Program(int red, int green, int blue, int alpha) {
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = alpha;

		}

		/// <summary>
		/// Creates a color with values of red, green & blue that is opaque.
		/// </summary>
		/// <param name="red"></param>
		/// <param name="green"></param>
		/// <param name="blue"></param>
		public Program(int red, int green, int blue) {
			this.red = red;
			this.green = green;
			this.blue = blue;
			this.alpha = 255;

		}

		public int GetRed() {
			return red;
		}
		public void SetRed(int red){
				this.red = red;
			}


		public int GetGreen() {
			return green;
		}
		public void SetGreen(int green) {
			this.green = green;
		}

		public int GetBlue() {
			return blue;
		} 
		public void SetBlue(int blue) {
			this.blue = blue;
		}

 /// <summary>
 /// These methods allow alpha variable to control the shading of the color created.
 /// </summary>
		public int GetAlpha() {
			return alpha;
		}  
		public void SetAlpha(int alpha){
				this.alpha = alpha;
			}


		public int GetGrayscale() {
			int grayscale = (int)((red + green + blue) / 3);
			return grayscale;
		}
	}
}
