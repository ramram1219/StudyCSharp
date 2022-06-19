using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BasicAlgorithm
{
	class Program
	{
		/*
		 * 땅 위에 달팽이가 있다. 이 달팽이는 높이가 10미터인 나무를 올라 가는 중이다.
		 * 달팽이는 낮에 3미터를 올라가고, 밤 잠을 자는 동안 2미터를 미끄러진다.
		 * 달팽이가 나무를 모두 올라가려면, 며칠이 걸리는지 구하시오.
		 */

		static void Main(string[] args)
		{
			int TreeHeight = 10;
			int WakeUp = 3;
			int Sleep = 2;

			int NowHeight = 0;
			int Day = 0;

			while(true)
			{
				NowHeight += WakeUp;
				Day++;

				if(NowHeight >= TreeHeight)
				{
					break;
				}

				NowHeight -= Sleep;
			}

			Console.WriteLine($"달팽이가 나무에 올라가는데 걸린 날 : {Day}일");
		}
	}
}
