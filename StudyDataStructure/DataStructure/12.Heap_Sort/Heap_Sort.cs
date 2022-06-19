using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Heap_Sort
{
	class Heap_Sort
	{
		public void SwapHeap(ref int data1, ref int data2)
		{
			int temp = data1;
			data1 = data2;
			data2 = temp;
		}

		public void CalcHeap(int[] arrayData, int root, int max)
		{
			while(root < max)
			{
				int child = root * 2 + 1;

				if ((child + 1 < max) && (arrayData[child] < arrayData[child + 1]))
				{
					++child;
				}

				if ((child < max) && (arrayData[root] < arrayData[child]))
				{
					SwapHeap(ref arrayData[root], ref arrayData[child]);
					root = child;
				}
				else
				{
					break;
				}
			}
		}
	}
}
