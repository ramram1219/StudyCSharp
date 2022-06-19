using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Queue
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayQueue arrayQueue = new ArrayQueue(5);

			arrayQueue.Enqueue(10);
			arrayQueue.Enqueue(20);
			arrayQueue.Enqueue(30);
			arrayQueue.Enqueue(40);
			arrayQueue.Enqueue(50);

			arrayQueue.PrintQueue();
		}
	}
}
