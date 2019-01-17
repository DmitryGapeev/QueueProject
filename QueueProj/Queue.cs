using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

	public class Queue<T>
	{
		private LinkedList<T> _items;
		public Queue()
		{
			_items = new LinkedList<T>();
		}

		public void Enqueue(T item)
		{
			_items.AddLast(new LinkedListNode<T>(item));
		}

		public T Dequeue()
		{
			if (_items.Count != 0)
			{
				T next = _items.First.Value;
				_items.RemoveFirst();
				return next;
			}
			return default(T);
		}

		public int Size()
		{
			return _items.Count;
		}

	}
}