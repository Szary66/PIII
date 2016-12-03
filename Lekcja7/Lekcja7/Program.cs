using System;

namespace Lekcja7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Zadanie1 ();	
		}


		//Zadnaie1*************************************************

		static void Zadanie1(){
			Bisekcja bis = new Bisekcja (2 / 3.0 * Math.PI, 4.0 / 3 * Math.PI, 1e-10);
			bis.Function = Math.Sin;

			bis.Solve ();
			Console.WriteLine (bis.Result);


		}


		//Zadanie2*****************************************************



					
	}
}