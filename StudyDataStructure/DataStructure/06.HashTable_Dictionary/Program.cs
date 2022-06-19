using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.HashTable_Dictionary
{
	class Program
	{
		/*
		 * 해쉬 테이블과 딕셔너리의 특징
		 * - 키를 가지고 빠르게 값에 접근하기에 좋다
		 * - 순서나 중복되는 데이터가 있는 경우에는 맞지 않다.
		 * - 미리 저장공간을 확보하기 때문에 메모리 효율이 좋지 않으나 검색 효율이 좋다.
		 * 
		 * 해쉬 테이블은 object로 인한 박싱과 언박싱이 발생하기 때문에 딕셔너리 사용을 권고
		 */

		static void Main(string[] args)
		{
			Console.WriteLine("Hashtable & Dictionary");

			Hashtable hash = new Hashtable();

			hash.Add(0, "정현");
			hash.Add(1, "C#");
			hash.Add(2, "자료구조");

			Console.WriteLine(hash[1]);

			Dictionary<string, string> dic = new Dictionary<string, string>();

			dic.Add("정현", "010-8582-0001");
			dic.Add("가람", "010-9291-0002");
			dic.Add("민정", "010-3133-0003");

			foreach (var item in dic.Keys)
			{
				Console.WriteLine(item + " : " + dic[item]);
			}

			if(!dic.ContainsKey("용희"))
			{
				dic.Add("용희", "010-3223-1212");
			}

			dic.Remove("가람");

			foreach (var item in dic.Keys)
			{
				Console.WriteLine(item + " : " + dic[item]);
			}
		}
	}
}
