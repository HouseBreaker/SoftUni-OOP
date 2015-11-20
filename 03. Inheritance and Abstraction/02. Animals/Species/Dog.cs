﻿using System;
using _02.Animals.Interfaces;

namespace _02.Animals.Species
{
	public class Dog : Animal
	{
		public Dog(string name, int age, string gender)
			: base(name, age, gender)
		{
		}

		public override void ProduceSound()
		{
			Console.WriteLine($"{this.Name} barks!");
		}
	}
}