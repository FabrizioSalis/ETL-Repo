using System;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
	public class Cow : Animal, IMilkableAnimal
	{
		public Cow() : base(4)
		{

		}

		public override void Talk()
		{
			Console.WriteLine("Cow says Moo!");
		}

		public override void Walk()
		{
			Console.WriteLine("Cow is walking");
		}

		public override void Run()
		{
			Console.WriteLine("Cow is running");
		}

		public void ProduceMilk()
		{
			Console.WriteLine("Cow was milked!");
		}

	}
}