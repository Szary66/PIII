using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;


namespace Lekcja5
{
	static class RozszerzonaKlasa{
		public static double GetDouble(this string value){

			return Convert.ToDouble(value);
		}

		public static DateTime GetDate(this string dateString){
			return Convert.ToDateTime(dateString, new CultureInfo("pl-PL")); 
		}


	}

	static class RozszerzenieLosowania{
		public static double NextDouble(this Random rand, double max){
			return rand.NextDouble() * max;
		}

		public static double NextDouble(this Random rand, double min, double max){
			
			return rand.NextDouble()*(max-min)+min;
		}
	}

	class KlasaInstancyjna{
		private static int counter = 0;

		public  KlasaInstancyjna(){
			++counter;
		}

		public static void Wyswietl(){
			Console.WriteLine (counter);
		}
	}

	static class KlasaStatyczna{
		static KlasaStatyczna(){
			Console.WriteLine ("Konstruktor statyczny tylko prywatny\nSam sie wywolalem!");
		}

		private static int counter = 0;

		public static void Wyswietl(){
			Console.WriteLine (counter);
		}

		public static void Inkrementacja(){
			++counter;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			//Wprowadzenie ();
			//Zadanie2();

			var k = new Kolejka<int> ();
			k.Push (5);
			k.Push (6);
			k.Wyswietl ();
			k.Pop ();
			k.Wyswietl ();
		}

		static void Wprowadzenie(){
			/*Console.WriteLine ("Podaj a: ");
			double a = Console.ReadLine ().GetDouble();
			Console.WriteLine (a);*/
			/*
			string date = "01/03/2016";
			Console.WriteLine (date.GetDate());
			*/
			/*Random rand = new Random ();				
			Console.WriteLine (rand.NextDouble(5, 7));*/

			KlasaStatyczna.Wyswietl ();
			KlasaStatyczna.Inkrementacja ();
			KlasaStatyczna.Wyswietl ();
		}

		public static void Zadanie2(){
			var stack = new Stack<double> ();
			stack.Push (4.5);
			stack.Push (1.5);
			stack.Push (3.5);

			stack.Display ();
		}
	}

	//Zadanie 1 ******************************************************
	class Konto{
		private double saldo;
		private string haslo = "password";

		private Person Osoba = new Person ();

		static double oprocentowanie;
		static double debet;

		public static void ZmianaOprocentowania(double noweOprocentowanie){
			oprocentowanie = noweOprocentowanie;
		}

		public static void ZmianaDebetu(double nowyDebet){
			debet = nowyDebet;
		}

		public void ZmienHaslo(string haslo){
			this.haslo = haslo;
		}

		/*

		public void Wplata(double wplata){
			saldo += wplata; 
		}
*/

	}

	class Person{
		public string pesel;
		public string imie;
		public string nazwisko;
	}

	//Zadanie 2***********************************************
	class Node<T>{
		public T value;
		public Node<T> next = null;
	}

	interface ISStack<T>{
		void Push (T value);

		T  Pop();
	}

	interface IDisplay{
		void Display ();
	}

	class Stack<T>:ISStack<T>, IDisplay, IEnumerable{
		private Node<T> _current = null;

		public T Pop(){
			if (_current == null)
				return default(T);

			var returnCurrect = _current.value;
			_current = _current.next;

			return returnCurrect;
		}

		public void Push(T element){
			Node<T> node = new Node<T> ();
			node.value = element;
			node.next = _current;
			_current = node;
		}

		public void Display(){
			foreach (var i in this) {
				Console.WriteLine (i);
			}
		}

		IEnumerator<T> GetEnumerator()
		{
			if(_current != null){
				do{
					yield return _current.value;
					_current = _current.next;
				}while(_current != null);
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator ();
		}


	}
}
