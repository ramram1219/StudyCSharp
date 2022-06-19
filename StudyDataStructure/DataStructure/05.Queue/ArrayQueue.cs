using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Queue
{
	class ArrayQueue
	{
		private int[] m_queue;
		private int front;
		private int rear;

		public ArrayQueue(int size)
		{
			m_queue = new int[size];
			front = -1;
			rear = -1;
		}

		public void Enqueue(int value)
		{
			rear++;

			if (rear - front > m_queue.Length - 1)
			{
				rear--;
				return;
			}

			m_queue[rear % m_queue.Length] = value;

			if (front == -1)
			{
				front = 0;
			}
		}

		public void Dequeue()
		{
			if (front == -1) return;

			int value = m_queue[front % m_queue.Length];

			m_queue[front % m_queue.Length] = 0;

			front++;

			if (front > rear)
			{
				front = -1;
				rear = -1;
			}

		}

		public void PrintQueue()
		{
			for (int i = 0; i < m_queue.Length; i++)
			{
				Console.WriteLine(m_queue[i] + " ");
			}
		}
	}
}
