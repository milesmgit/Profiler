using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MealProfiler.Models;

namespace MealProfiler.Data
{
	public class Data
	{

		// so when we need a Meals List, we call the method InitData; below Data.Meals is the result so we just call for that, and then do some Linq processing if desired.
		public static List<Meal> Meals { get; set; }

		// this will be called , that will then call the initialization of two lists of data.
		static Data()
		{
			InitData();
		}

		private static void InitData()
		{
			// instantiate and provide the parameter values for 1 list.
			// create the collection of Meals first so that we can refeence them when building our list of meal Profiles.
			// use a local var meals to handle the processing, and then pass to the property Meals.
			var meals = new List<Meal>()
			{
				new Meal(Meal.MealType.HeartHealthy, "Heart Healthy"),
				new Meal(Meal.MealType.DiabetesPrevention, "Diabetes Prevention"),
				new Meal(Meal.MealType.EnergyBoost, "Boost Energy"),
				new Meal(Meal.MealType.DigestiveHealth, "Digestive Health"),
				new Meal(Meal.MealType.MuscleGrowth, "Muscle Growth"),
				new Meal(Meal.MealType.FatLoss, "Fat Loss"),
			};

			Meals = meals;
		


		}




	}
}