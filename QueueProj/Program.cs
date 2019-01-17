using System;

namespace AlgorithmsDataStructures
{
	class Program
	{
		static void Main(string[] args)
		{
			TestQueue();
			TestBaseOnTwoStacks();

			Console.WriteLine("test QueueCircle");
			Queue<int> queue = new Queue<int>();
			for (int i = 1; i <= 10; i++)
				queue.Enqueue(i);

			QueueCircle(queue, 12);

			while (queue.Size() != 0)
				Console.Write(queue.Dequeue() + " ");

			Console.ReadKey();
		}

		static void TestQueue()
		{
			Console.WriteLine("test queue ");
			Queue<int> queue = new Queue<int>();

			Console.Write("enqueue into queue ");
			for (int i = 1; i <= 10; i++)
			{
				Console.Write(i + " ");
				queue.Enqueue(i);
			}
			Console.WriteLine();
			Console.WriteLine("size after enqueue = " + queue.Size());

			Console.Write("dequeue from queue ");
			for (int i = 1; i <= 10; i++)
			{
				int item = queue.Dequeue();
				Console.Write(item + " ");
			}
			Console.WriteLine();
			Console.WriteLine("size after dequeue = " + queue.Size());

			Console.WriteLine("dequeue from empty queue");
			int result = queue.Dequeue();
			Console.WriteLine("result = " + result);

			Console.WriteLine(new string('=', 50));
		}

		// задание 3
		static void QueueCircle<T>(Queue<T> queue, int n)
		{
			if (queue.Size() == 0 || queue.Size() == 1)
				return;

			for (int i = 0; i < n; i++)
			{
				T item = queue.Dequeue();
				queue.Enqueue(item);
			}
		}

		static void TestBaseOnTwoStacks()
		{
			Console.WriteLine("test queue base on two stacks ");
			QueueBaseOnTwoStacks<int> queue = new QueueBaseOnTwoStacks<int>();

			Console.WriteLine("enqueue into queue ");
			for (int i = 1; i <= 10; i++)
			{
				Console.Write(i + " ");
				queue.Enqueue(i);
			}
			Console.WriteLine();
			Console.WriteLine("size after enqueue = " + queue.Size());

			Console.WriteLine("dequeue 5 elements");
			for (int i = 0; i < 5; i++)
				Console.Write(queue.Dequeue() + " ");
			Console.WriteLine("size after qeueue = " + queue.Size());

			Console.WriteLine("dequeue 5 elements");
			for (int i = 0; i < 5; i++)
				Console.Write(queue.Dequeue() + " ");
			Console.WriteLine("size after qeueue = " + queue.Size());

			Console.WriteLine("dequeue from empty queue");
			int result = queue.Dequeue();
			Console.WriteLine("result = " + result);

			Console.WriteLine(new string('=', 50));
		}
	}
}
