using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MealProfiler.Models
{
	public class Meal
	{
		public enum MealType
		{
			HeartHealthy = 1,
			DiabetesPrevention = 2,
			FatLoss = 3,
			MuscleGrowth = 4,
			EnergyBoost = 5,
			DigestiveHealth = 6
		}

		/// <summary>
		/// Constructors an meal for the provided meal type and name.
		/// </summary>
		/// <param name="mealType">The meal type for the meal.</param>
		/// <param name="name">The name for the meal.</param>
		public Meal(MealType mealType, string name = null)
		{
			Id = (int)mealType;

			// If we don't have a name argument, 
			// then use the string representation of the meal type for the name.
			Name = name ?? mealType.ToString();
		}

		/// <summary>
		/// The Meal_ID of the meal from the MealType enum.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The name of the meal from the MealType enum; we use this to reference it in a list.
		/// </summary>   we can use this with the Meal Goal returned like this:  Profile.Meal.Name  
		/// or @Model.Meal.Name
		public string Name { get; set; }





	}
}