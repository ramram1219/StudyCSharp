using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingOut
{
	class Program
	{
		// a, b는 input을 받기위한 변수, quontient와 remainder는 output을 받기 위한 변수이다. 
		static void Divide(int a, int b, out int quontient, out int remainder)
		{
			quontient = a / b;
			remainder = a % b;
		}

		static void Main(string[] args)
		{
			int a = 20, b = 3;

			Divide(a, b, out int c, out int d);
			Console.WriteLine($"Divide({a}, {b}) = quo({c}), rem({d})");
		}
	}
}
