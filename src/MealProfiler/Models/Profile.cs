using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MealProfiler.Models
{
	public class Profile
	{


		public Profile()
		{


		}

		/// <summary>
		/// Constructor 
		/// </summary>
		/// <param name="profileid">The ID for the meal Profile.</param>  so we can keep track of which meal profile submission is which
		/// <param name="mealType">The meal type Profile passed to the MealGoal from the casting of the (int)MealType enum from the dropdown box</param>  
		/// <param name="prepTime">The duration for the meal Profile (in minutes).</param>
		/// <param name="mealCost">The cost for the meal Profile (in US Dollars).</param>
		/// <param name="mealAuthor">  Person that created the meal. </param>
		/// <param name="spinachQuantity">The ID for the textbox, whose value will be assigned to spinachQuantity if checked first. on form submit</param>
		/// <param name="tomatoQuantity"></param>
		/// <param name="spinachCheckbox">The ID for the spinachCheckBox.</param>
		/// <param name="tomatoCheckbox"></param>
		/// <param name="notes">The notes for the meal Profile.</param>
		public Profile(int profileid, Meal.MealType mealType,
				int prepTime, double mealCost, string mealAuthor, double spinachQuantity,
				double tomatoQuantity, bool spinachCheckbox = false, bool tomatoCheckbox = false, 
				string notes = null)

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
		/// The ID of the meal Profile order it was placed in apparently..
		/// </summary>
		public int ProfileId { get; set; }

		/// <summary>
		/// We need using System.Component.DataAnnotation; for this
		/// The meal ID for the meal Profile. The ID value should map to an ID in the meals collection.
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
		/// The prepTime for the meal Profile (in minutes).
		/// </summary>
		[Range(typeof(int), "1", "100000")]
		public int PrepTime { get; set; }

		[Range(typeof(double), ".01", "1000000000")] // billionaires have to eat too!
		public double MealCost { get; set; }

		
		public string MealAuthor { get; set; }

		public bool SpinachCheckbox { get; set; }
		public bool TomatoCheckbox { get; set; }


		public double? SpinachQuantity { get; set; }


		public double? TomatoQuantity { get; set; }

		/// <summary>
		/// The notes for the meal Profile.
		/// </summary>

		[MaxLength(200, ErrorMessage = "200 Character Limit for this Notes Field.")]
		public string Notes { get; set; }






	}
}