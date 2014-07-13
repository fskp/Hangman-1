using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	// Singleton
	public class RandomGenerator
	{
		private static RandomGenerator instance = null;

		private Random randomObject;

		private RandomGenerator()
		{
			this.randomObject = new Random();
		}

		public static RandomGenerator Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new RandomGenerator();
				}

				return instance;
			}
		}

		public int GetRandomNumber(int min, int max)
		{
			return this.randomObject.Next(min, max);
		}
	}
}
