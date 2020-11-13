/*
* Author: Samuel McGowan
* Class name: ThugsTBone.cs
* Purpose: To hold information for the Thugs T-Bone
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Public class representing the Thugs T-Bone
	/// </summary>
	public class ThugsTBone : Entree, INotifyPropertyChanged
	{
		/// <summary>
		/// This does nothing because no property ever changes
		/// </summary>
		public override event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Property that returns the ToString method
		/// </summary>
		public string Name
		{
			get
			{
				return (ToString());
			}
		}

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
		/// <summary>
		/// The description of this entree
		/// </summary>
		public override string Description { get; } = "Juicy T-Bone, not much else to say.";
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
