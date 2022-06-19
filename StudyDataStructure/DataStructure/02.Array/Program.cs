using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array
{
	class Program
	{
		/*
		 * Array - 크기가 정해져 있고, 데이터의 추가나 삭제 등의 변화가 없는 경우 사용하기 좋음
		 * 
		 * 로또 번호 추출 코드 예제
		 */

		static void Main(string[] args)
		{

			Lotto lotto = new Lotto();
			
		}

		class Lotto
		{
			private int[] number;

			public Lotto()
			{
				GetNumber();
			}

			private void GetNumber()
			{
				Random rnd = new Random();
				int index = 0;

				number = new int[6];

				while(index < number.Length)
				{
					int temp = rnd.Next(1, 46);

					if (IsSameNumber(index, temp))
					{
						continue;
					}

					number[index++] = temp;
				}

				for(int i = 0; i < number.Length; i++)
				{
					Console.Write(number[i] + " ");
				}
			}

			private bool IsSameNumber(int index, int temp)
			{
				for(int i = 0; i < index; i++)
				{
					if(number[i] == temp)
					{
						return true;
					}
				}

				return false;
			}
		}
	}
}
