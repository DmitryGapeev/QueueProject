using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
	class QueueBaseOnTwoStacks<T>
	{
		private readonly Stack<T> _stackForEnqueue;
		private readonly Stack<T> _stackForDequeue;

		public QueueBaseOnTwoStacks()
		{
			_stackForEnqueue = new Stack<T>();
			_stackForDequeue = new Stack<T>();
		}

		public int Size()
		{
			return _stackForEnqueue.Count + _stackForDequeue.Count;
		}

		public void Enqueue(T item)
		{
			_stackForEnqueue.Push(item);
		}

		public T Dequeue()
		{
			if (_stackForDequeue.Count == 0)
			{
				if (_stackForEnqueue.Count == 0)
					return default(T);

				while (_stackForEnqueue.Count != 0)
					_stackForDequeue.Push(_stackForEnqueue.Pop());
			}

			return _stackForDequeue.Pop();
		}
	}
}
