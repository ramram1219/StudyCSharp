using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Stack
{
	class ArrayStack
	{
		private int[] m_space;  // 스택의 전체 공간
		private int m_top;      // 스택의 최상단을 가리킴
		public int Count;       // 스택에 추가 된 데이터의 갯수

		public ArrayStack(int size)
		{
			m_space = new int[size];
			m_top = -1;
		}

		public void Push(int value)
		{
			m_top++;
			m_space[m_top] = value;

			Count++;
		}

		public int Pop()
		{
			int value = m_space[m_top];

			m_space[m_top] = 0;
			m_top--;

			Count--;

			return value;
		}

		public bool IsEmpty()
		{
			return m_top == -1;
		}

		public bool IsFull()
		{
			return m_top == m_space.Length - 1;
		}
	}
}
