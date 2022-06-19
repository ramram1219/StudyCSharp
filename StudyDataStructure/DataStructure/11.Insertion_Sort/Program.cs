using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Insertion_Sort
{
	class Program
	{
		/*
		 * 삽입 정렬 - 앞의 숫자가 나보다 큰지 비교하면서 자신의 위치에 삽입하는 정렬 방법.
		 *           - 앞의 값과 비교를 하기 때문에 전체 배열 중 0번 인덱스가 아닌 1번 인덱스부터 비교.
		 */

		static void Main(string[] args)
		{
			int[] data = { 20, 15, 1, 5, 10 };

			for(int i = 1; i < data.Length; i++)
			{
				int key = i;

				for(int j = i - 1; j >= 0; j--)
				{
					if(data[key] < data[j])
					{
						int temp = data[j];
						data[j] = data[key];
						data[key] = temp;
						key = j;
					}
					else
					{
						break;
					}
				}

				for(int k = 0; k < data.Length; k++)
				{
					Console.Write(data[k] + ", ");
				}
				Console.WriteLine();
			}
		}
	}
}
