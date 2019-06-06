using System;
using System.Collections.Generic;
using System.Linq;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
	public class EmydexFarmSystem
	{
		public event EventHandler<EventArgs> FarmEmpty;

		public Queue<Animal> Animals { get; set; }
		public EmydexFarmSystem()
		{
			Animals = new Queue<Animal>();
		}

		//TEST 1
		public void Enter(Animal animal)
		{
			Animals.Enqueue(animal);
			Console.WriteLine($"{animal.Name} has entered the Emydex Farm");
		}

		//TEST 2
		public void MakeNoise()
		{
			foreach (var animal in Animals)
			{
				animal.Talk();
			}
		}

		//TEST 3
		public void MilkAnimals()
		{
			foreach (var animal in Animals.OfType<IMilkableAnimal>())
			{
				animal.ProduceMilk();
			}
		}

		//TEST 4
		public void ReleaseAllAnimals()
		{
			while (Animals.Any()) {
				var animal = Animals.Dequeue();
				Console.WriteLine($"{animal.Name} has left the farm");
			}
			Animals.Clear();
			FarmEmpty?.Invoke(this, new EventArgs());
		}
	}
}