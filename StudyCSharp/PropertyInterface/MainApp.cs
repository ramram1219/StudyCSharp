﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInterface
{
	interface INamedValue
	{
		string Name { get; set; }
		string Value { get; set; }
		string GetOtherValue();
	}

	abstract class Product
	{
		private static int Serial = 0;

		public string SerialID
		{
			get { return String.Format($"{Serial++:ds}"); }
		}

		abstract public DateTime ProductDate { get; set; }
	}
	
	class MyProduct : Product
	{
		public override DateTime ProductDate { get; set; }
	}

	class Namedvalue : INamedValue
	{
		public string Name { get; set; }
		public string Value { get; set; }

		public string GetOtherValue()
		{
			return "Value";
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Namedvalue name = new Namedvalue
			{
				Name = " 이름",
				Value = "김가람"
			};

			Namedvalue height = new Namedvalue
			{
				Name = " 키",
				Value = "166cm"
			};

			Namedvalue weight = new Namedvalue
			{
				Name = "몸무게",
				Value = "비밀"
			};
		}
	}
}
