﻿using System;

namespace FarmSystem.Test1
{
	public class Hen : Animal
	{
		public Hen() : base(2)
		{

		}

		public override void Talk()
		{
			Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
		}

		public override void Run()
		{
			Console.WriteLine("Hen is running");
		}

	}
}