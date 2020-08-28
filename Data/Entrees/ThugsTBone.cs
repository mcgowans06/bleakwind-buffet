/*
* Author: Samuel McGowan
* Class name: ThugsTBone.cs
* Purpose: To hold information for the Thugs T-Bone
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	class ThugsTBone
	{
		// Default Properties
		public double Price { get; private set; } = 6.44;
		public uint Calories { get; private set; } = 982;
		public List<String> SpecialInstructions = new List<string>();

		// ToString Override
		public override string ToString()
		{
			return ("Thugs T-Bone");
		}
	}
}
