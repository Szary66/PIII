using System;
using System.Collections.Generic;
using System.Collections;


namespace Lekcja5
{
	interface IKolejka<T>{
		void Push(T item);

		T Pop();
	}

	interface IWyswietl<T>{
		void Wyswietl(); 
	}

	class KolejkaNode<T>{
		public T value;
		public KolejkaNode<T> next = null;
		public KolejkaNode<T> previous = null;
	}



	public class Kolejka<T>: IKolejka<T>, IWyswietl<T>, IEnumerable
	{
		KolejkaNode<T> _head = null;
		KolejkaNode<T> _tail = null;

		public void Push(T element){
			KolejkaNode<T> node = new KolejkaNode<T> ();
			node.value = element;
			node.next =  null;

			if (_head != null) {
				_tail.next = node;
			} else {
				_head = node;
			}

			_tail.next = node;
			_tail = node;
		}

		public T  Pop(){
			if(_head == null)
				return default(T);

			var returnValue = _head.value;
			_head = _head.next;

			return returnValue;
		}

		public void Wyswietl(){
			foreach (var i in this) {
				Console.WriteLine (i);
			}
		}

		IEnumerator<T> GetEnumerator()
		{
			var tail = _tail;
			if(tail != null){
				do{
					yield return tail.value;
					_tail = tail.next;
				}while(tail != null);
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator ();
		}
	}
}

