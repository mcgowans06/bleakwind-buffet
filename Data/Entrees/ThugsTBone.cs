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
	/// <summary>
	/// Public class representing the Thugs T-Bone
	/// </summary>
	public class ThugsTBone
	{
		// Default Properties
		/// <summary>
		/// Prive of this entree
		/// </summary>
		public double Price { get; private set; } = 6.44;
		/// <summary>
		/// Calories of this entree
		/// </summary>
		public uint Calories { get; private set; } = 982;
		/// <summary>
		/// Empty list that stores the special instructions
		/// </summary>
		public List<String> SpecialInstructions = new List<string>();

		// ToString Override
		/// <summary>
		/// Returns a description of this entree
		/// </summary>
		/// <returns>A string describing this entree</returns>
		public override string ToString()
		{
			return ("Thugs T-Bone");
		}
	}
}
