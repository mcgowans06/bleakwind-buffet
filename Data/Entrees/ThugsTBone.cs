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
	public class ThugsTBone : Entree
	{
		// Default Properties
		/// <summary>
		/// Prive of this entree
		/// </summary>
		public override double Price { get; } = 6.44;
		/// <summary>
		/// Calories of this entree
		/// </summary>
		public override uint Calories { get; } = 982;
		/// <summary>
		/// Empty list that stores the special instructions
		/// </summary>
		public override List<string> SpecialInstructions { get;} = new List<string>();

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
