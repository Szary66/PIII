using System;

namespace Lekcja7
{
	public class Bisekcja
	{
		public Bisekcja (double left, double right, double eps)
		{
			_left = left;
			_right = right;
			_eps = eps;
		}

		private double _left;
		private double _right;
		private double _eps;
		private double _result;


		public double Left{
			get{ return _left;}
			set{ _left = value;}
		}

		public double Right{
			get{ return _right;}
			set{ _right = value;}
		}


		public double Epsilon{
			get{ return _eps;}
			set{ _eps = value;}
		}

		public double Result{
			get{return _result; }
			set{ _result = value; }
		}

		public Func <double, double> Function{ get; set;}

		public void Solve(){
			double result;
			if (Function == null)
				throw new ArgumentOutOfRangeException ("Funckja musi byc zdefiniowana");
			if (Function (Left) * Function (Right) > 0)
				throw new ArgumentOutOfRangeException ("Funkcja musi zmieniac znaki na koncach przedzilu");

			do{
				double midpoint = (Left + Right)/2;
				Result = midpoint;

				if(Math.Abs(Function(midpoint)) < Epsilon)
					break;

				if(Function(Left) * Function(midpoint)<0)
					Right = midpoint;
				else 
					Left = midpoint;
			}while(Math.Abs(Left-Right) > Epsilon);					
		}
	}
}

