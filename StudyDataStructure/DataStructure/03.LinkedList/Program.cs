using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LinkedList
{
	class Program
	{
		/*
		 * Linked List - 데이터 추가/삭제에 대한 연산이 불필요하다
		 *             - 동적으로 구현된다.
		 *             - 탐색 연산의 비용이 높다(데이터 조회 시 비용이 높다)
		 *             
		 * C#의 LinkedList<>는 양방향 리스트로 구현되어 있다. 
		 * 
		 * 단방향 연결 리스트 구현 예제 
		 */

		static void Main(string[] args)
		{
			SinglyLinkedList<int> list = new SinglyLinkedList<int>();

			list.AddLast(1);
			list.AddLast(2);
			list.AddLast(3);
			list.AddLast(4);
			list.AddLast(5);

			list.AddFirst(0);

			Node<int> find = list.Find(3);

			list.AddAfter(find, 10);

			list.Remove(find);

			Console.WriteLine(list.ToString());
		}
	}
}
