﻿using System;

namespace FarmSystem.Test1
{
	public class Horse : Animal
	{
		public Horse() : base(4)
		{

		}
		public override void Talk()
		{
			Console.WriteLine("Horse says neigh!");
		}

		public override void Run()
		{
			Console.WriteLine("Horse is running");
		}

	}
}