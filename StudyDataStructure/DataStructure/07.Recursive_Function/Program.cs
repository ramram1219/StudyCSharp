using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Recursive_Function
{
	class Program
	{
		/*
		 * 재귀 호출 - 반드시 중지되어야 한다(기저 조건, 종료 조건), 스택 오버플로우 주의 해야 함. 
		 * 
		 * Factorial, Fibonacci Sequence 예제
		 */

		static void Main(string[] args)
		{
			Console.WriteLine("Factorial(5) = " + FuncFactorial(5));
			Console.WriteLine("Fibonacci(5) = " + FuncFibonacci(5));

		}

		static public int FuncFactorial(int number)
		{
			int result = 0;

			if(number == 1)
			{
				result = 1;
			}
			else
			{
				result = number * FuncFactorial(number - 1);
			}

			return result;
		}

		static public int FuncFibonacci(int number)
		{
			int result = 0;

			if(number == 1 || number == 2)
			{
				result = 1;
			}
			else
			{
				result = FuncFibonacci(number - 1) + FuncFibonacci(number - 2);
			}

			return result;
		}
	}
}
