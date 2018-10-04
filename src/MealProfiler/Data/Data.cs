using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MealProfiler.Models;

namespace MealProfiler.Data
{
	public class Data
	{

		// we will use this to reference a dropdown list for our AddEdit form.
		public static List<Meal> Meals { get; set; }

		// this will be called , that will then call the initialization of a list of data.
		static Data()
		{
			InitData();
		}

		public static void InitData()
		{
			// instantiate and provide the parameter values for 1 list.
			// create the collection of Meals first so that we can reference them when building our list of meal Profiles.
			// use a local var meals to handle the processing, and then pass to the property Meals.
			var meals = new List<Meal>()
			{
				new Meal(Meal.MealType.Heart_Healthy, "Heart Healthy"),
				new Meal(Meal.MealType.Diabetes_Prevention, "Diabetes Prevention"),
				new Meal(Meal.MealType.Energy_Boost, "Boost Energy"),
				new Meal(Meal.MealType.Digestive_Health, "Digestive Health"),
				new Meal(Meal.MealType.Muscle_Growth, "Muscle Growth"),
				new Meal(Meal.MealType.Fat_Loss, "Fat Loss"),
			};

			Meals = meals;
		


		}




	}
}