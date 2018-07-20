using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MealProfiler.Models
{
	public class ProfileViewModel
	{

		/// <summary>
		/// The MeasurementUnit of the Meal.
		/// </summary>
		public enum MeasurementUnit
		{
			Ounces,
			Grams
		}

		public ProfileViewModel()
		{


		}

		/// <summary>
		/// Constructor for easily creating mealProfiles.
		/// </summary>
		/// <param name="profileid">The ID for the meal.</param> 
		/// <param name="mealType">The meal type  passed to the MealGoal from the casting of the (int)MealType enum..</param>  dropdownbox
		/// <param name="prepTime">The duration for the meal(in minutes).</param>
		/// <param name="mealCost">The cost for the meal  (in US Dollars).</param>
		/// <param name="mealAuthor">Person the created the meal.</param>
		/// <param name="spinachQuantity">The ID for the textbox, whose value will be assigned to spinachQuantity if checked first. on form submit</param>
		/// <param name="tomatoQuantity"></param>
		/// <param name="spinachCheckbox">The ID for the spinachCheckBox.</param>
		/// <param name="tomatoCheckbox"></param>
		/// <param name="notes">The notes for the meal .</param>
		public ProfileViewModel(int profileid, Meal.MealType mealType,
				int prepTime, double mealCost, string mealAuthor, double spinachQuantity,
				double tomatoQuantity,
				bool spinachCheckbox = false, bool tomatoCheckbox = false, string notes = null)

		{
			ProfileId = profileid;
			// will return a number referencing the type of meal from a enum list.
			MealGoal = (int)mealType;
			PrepTime = prepTime;
			MealCost = mealCost;
			MealAuthor = mealAuthor;
			SpinachQuantity = spinachQuantity;
			TomatoQuantity = tomatoQuantity;
			SpinachCheckbox = spinachCheckbox;
			TomatoCheckbox = tomatoCheckbox;
			Notes = notes;
		}

		/// <summary>
		/// The ID of the meal
		/// </summary>
		public int? ProfileId { get; set; }

		/// <summary>
		/// We need using System.Component.DataAnnotation; 
		/// The meal ID for the meal. The ID value should map to an ID in the meals collection.
		/// </summary>
		/// 

		[Display(Name = "Meal")]
		public int MealGoal { get; set; }
		// a number that corresponds to the type of meal.

		/// <summary>
		/// The meal for the meal Profile.
		/// </summary>
		public Meal Meal { get; set; }

		/// <summary>
		/// The prepTime for the meal(in minutes).
		/// </summary>
		[Display(Name = "Prep Time")]
		[Range(typeof(int), "1", "100000")]
		public int PrepTime { get; set; }

		[Display(Name = "Meal Cost")]
		[Range(typeof(double), ".01", "1000000000")] // billionaires have to eat too!
		public double MealCost { get; set; }

		
		public string MealAuthor { get; set; }

		public bool SpinachCheckbox { get; set; }
		public bool TomatoCheckbox { get; set; }


		public double? SpinachQuantity { get; set; }


		public double? TomatoQuantity { get; set; }




		/// <summary>
		/// The notes for the meal.
		/// </summary>

		[MaxLength(200, ErrorMessage = "200 Character Limit for this Notes Field.")]
		public string Notes { get; set; }






	}
}