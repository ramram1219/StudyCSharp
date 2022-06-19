using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Quick_Sort
{
	class Program
	{
		/*
		 * 퀵 정렬 - 피봇을 기준으로 작거나 같은 값을 지닌 데이터는 앞으로, 큰 값을 지닌 데이터는 뒤로 가도록하여 
		 *           작은 값을 갖는 데이터와 큰 값을 갖는 데이터로 분리해가며 정렬하는 방법
		 *           1. 분할 정복 알고리즘
		 *           2. 일반적으로 빠른 알고리즘
		 * 
		 * 속도가 빠르다.
		 * 정렬된 리스트에 한하여 수행시간이 더 오래 걸린다. 
		 */

		static int[] data = { 25, 15, 60, 45, 10, 20, 5, 30 };

		static void Main(string[] args)
		{
			Console.Write("시작값 : ");
			for (int i = 0; i < data.Length; i++)
			{
				Console.Write(data[i] + ", ");
			}
			Console.WriteLine();

			SortQuick(0, data.Length - 1);

			Console.Write("정렬값 : ");
			for (int i = 0; i < data.Length; i++)
			{
				Console.Write(data[i] + ", ");
			}
			Console.WriteLine();
		}

		static void SortQuick(int first, int last)
		{
			if(first < last)
			{
				int pivotIndex = FuncPartition(first, last);

				SortQuick(first, pivotIndex - 1);
				SortQuick(pivotIndex + 1, last);
			}
		}

		static int FuncPartition(int first, int last)
		{
			int low, high, pivot;

			pivot = data[last];

			low = first;
			high = last - 1;

			while(low <= high)
			{
				while (data[low] < pivot) low++;

				while (data[high] > pivot) high++;

				if(low <= high)
				{
					Swap(data, low, high);
				}
			}

			Swap(data, low, last);

			return low;
		}

		static void Swap(int[] arrayData, int a, int b)
		{
			int temp = arrayData[a];
			arrayData[a] = arrayData[b];
			arrayData[b] = temp;
		}
	}
}
