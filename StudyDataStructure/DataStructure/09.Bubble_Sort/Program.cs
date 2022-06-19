using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Bubble_Sort
{
	class Program
	{
		/*
		 * 버블 정렬 - 서로 이웃한 데이터들을 비교하며 가장 큰 데이터를 가장 뒤로 보내는 정렬방식
		 *             1. 첫번째 데이터와 두번째 데이터를 비교하여 첫번째 값이 더 크면 두번째 값과 교환
		 *             2. 두번째 데이터와 세번째 데이터를 비교하여 더 큰 수를 뒤로 보낸다.
		 *             3. 처음부터 n-1번쨰 데이터를 비교해서 정렬하는 알고리즘
		 *  
		 *  배열의 모든 요소와 교환 해야한다. 
		 *  이미 정렬이 된 데이터도 교환되는 일이 발생된다. 
		 */

		static void Main(string[] args)
		{
			int[] data = { 20, 1, 5, 15, 10 };

			Console.Write("시작값 : ");
			for (int i = 0; i < data.Length; i++)
			{
				Console.Write(data[i] + ", ");
			}
			Console.WriteLine();

			for (int i = 0; i < data.Length - 1; i++)
			{
				for(int j = 0; j < data.Length - 1 - i; j++)
				{
					if(data[j] > data[j + 1])
					{
						Swap(ref data[j], ref data[j + 1]);
					}

					Console.Write((i + 1) + "번째 정렬값(" + j + ", " + (j + 1) + ") : ");
					for (int k = 0; k < data.Length; k++)
					{
						Console.Write(data[k] + ", ");
					}
					Console.WriteLine();
				}
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
