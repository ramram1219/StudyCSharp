﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
	class ArmorSuite
	{
		public virtual void Initialize()
		{
			Console.WriteLine("Armored");
		}
	}

	class IronMan : ArmorSuite
	{
		public override void Initialize()
		{
			base.Initialize();
			Console.WriteLine("Repulsor Rays Armod");
		}
	}

	class WarMachine : ArmorSuite
	{
		public override void Initialize()
		{
			base.Initialize();
			Console.WriteLine("Double-Barrel Cannons Armed");
			Console.WriteLine("Micro-Rocket Launcher Armed");
		}
	}
	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Createing ArmorSuite...");
			ArmorSuite armorsuite = new ArmorSuite();
			armorsuite.Initialize();

			Console.WriteLine("\nCreating IronMan...");
			ArmorSuite ironman = new IronMan();
			ironman.Initialize();

			Console.WriteLine("\nCreating WarMachine...");
			ArmorSuite warmachine = new WarMachine();
			warmachine.Initialize();
		}
	}
}
