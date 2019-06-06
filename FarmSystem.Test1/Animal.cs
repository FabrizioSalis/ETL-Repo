using System;

namespace FarmSystem.Test1
{
	public class Animal
	{
		public string Id { get; set; }
		public int NoOfLegs { get; set; }
		public string Name => GetType().Name;

		public Animal(int noOfLegs)
		{
			Id = Guid.NewGuid().ToString();
			NoOfLegs = noOfLegs;
		}

		public virtual void Talk()
		{
		}

		public virtual void Run()
		{
		}

		public virtual void Walk()
		{

		}
	}
}
