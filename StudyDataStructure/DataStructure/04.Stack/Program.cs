using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Stack
{
	class Program
	{
		/*
		 * Stack - LIFO(Last In First Out)
		 *       - 브라우저, 휴대폰의 화면 이동 방식 -> 뒤로 가기
		 *       - Ctrl + z
		 * 
		 * C#의 Stack은 리스트로 구현되어 있음(제너릭 타입과 아닌 형식 두 가지 모두 구현되어 있지만 제너릭 타입을 사용하도록 권고)
		 * Stack<T>
		 * 
		 * array type의 stack 예제 
		 */

		static void Main(string[] args)
		{
			ArrayStack arrayStack = new ArrayStack(5);
			//Stack<int> stack = new Stack<int>();

			arrayStack.Push(1);
			arrayStack.Push(2);
			arrayStack.Push(3);
			arrayStack.Push(4);
			arrayStack.Push(5);

			//stack.Push(0);
			//stack.Push(1);
			//stack.Push(2);
			//stack.Push(3);
			//stack.Peek();
			//stack.Pop();

			while(arrayStack.Count > 0)
			{
				Console.WriteLine(arrayStack.Pop());
			}
		}
	}
}
