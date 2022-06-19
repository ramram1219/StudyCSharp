using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Heap_Sort
{
	class Program
	{
		/*
		 * 힙 정렬 - 완전 이진 트리 구조를 가진 자료 구조
		 *         - 최소값 혹은 최대값을 빠르게 가져오기 위해 고안됨
		 *         - 형제 노드 사이에서는 아무런 대소 관계가 정해져 있지 않음
		 */

		static void Main(string[] args)
		{
			int[] arrayData = { 20, 35, 15, 5, 40, 10, 25, 30 };
			Heap_Sort heapSort = new Heap_Sort();

			// 트리 형태 정렬
			for(int i = (arrayData.Length - 1) / 2; i >= 0; --i )
			{
				heapSort.CalcHeap(arrayData, i, arrayData.Length);
			}
			
			// 데이터 정렬
			for(int i = arrayData.Length - 1; i > 0; --i)
			{
				heapSort.SwapHeap(ref arrayData[i], ref arrayData[0]);
				heapSort.CalcHeap(arrayData, 0, i);
			}
		}

	}
}
