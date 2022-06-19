using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Selection_Sort
{
	class Program
	{
		/*
		 * 선택 정렬 - 정렬되지 않은 데이터들에 대해 가장 작은 데이터를 찾아 가장 앞의 데이터와 교환
		 *             1. 리스트에서 최소값을 찾는다
		 *             2. 최소값을 맨 앞의 값과 교체한다.
		 *             3. 교체한 맨 앞의 데이터는 정렬 된 것으로 간주하고 다음 인덱스부터 다시 반복한다. 
		 * 
		 * 구현은 단순하지만 비효율적임 -> 두 개의 for 루프 실행
		 * 
		 * Big-O 표기법
		 * 1. O(1)
		 * 2. O(log n)
		 * 3. O(n)
		 * 4. O(n log n)
		 * 5. O(n^2)
		 */

		static void Main(string[] args)
		{
			int[] data = { 20, 15, 1, 5, 10 };

			Console.Write("시작값 : ");
			for (int i = 0; i < data.Length; i++)
			{
				Console.Write(data[i] + ", ");
			}
			Console.WriteLine();

			for(int i = 0; i < data.Length; i++)
			{
				int min = i;

				for(int j = i + 1; j < data.Length; j++)
				{
					if(data[min] > data[j])
					{
						min = j;
					}

				}
				Swap(ref data[i], ref data[min]);

				for (int k = 0; k < data.Length; k++)
				{
					Console.Write(data[k] + ", ");
				}
				Console.WriteLine();
			}

			Console.Write("정렬값 : ");
			for (int i = 0; i < data.Length; i++)
			{
				Console.Write(data[i] + ", ");
			}
			Console.WriteLine();


		}

		static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}
