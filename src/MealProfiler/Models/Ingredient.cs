using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MealProfiler.Data;

namespace MealProfiler.Models
{
	public class Ingredient
	{

		// Ingredient.cs is basically used to store static information.

		public int Id { get; set; }  // Id will set the starting value for the initial ingredient displayed on the Detail View
		public string IngredientName { get; set; }


		// interesting facts about spinach
		public string IngredientDescriptionHtml { get; set; }

		//  this will convert the Ingredient to a image .jpg path
		public string IngredientDetailFileName
		{
			get
			{
				//  IngredientName followed by .jpg, no space between .jpg and the IngredientName.
				return $"{IngredientName.ToLower()}.jpg";
			}
		}



		// testing a dictionary transplant for two dictionaries.
		public static Dictionary<int, string> TotalsDictionary = new Dictionary<int, string>
		{
			{ 1, "Total: Vitamin A"  },
			{ 2, "Total: Vitamin B" },
			{ 3, "Total: Vitamin C"  },
			{ 4, "Total: Calories"  },
			{ 5, "Total: Fat" },
			{ 6, "Total: Protein"  },
			{ 7, "Total: Carbohydrates"  },
			{ 8, "Total: Sugar" },
			{ 9, "Total: Sodium"  },
		};

		// testing a dictionary transplant for two dictionaries.
		public static Dictionary<string, double> SpinachDictionary = new Dictionary<string, double>
		{
			{ "Spinach: Base Vitamin A", 11  },
			{ "Spinach: Base Vitamin B", 27  },
			{ "Spinach: Base Vitamin C", 33  },
			{ "Spinach: Calories", 43  },
			{ "Spinach: Total Fat", 56  },
			{ "Spinach: Protein", 19  },
			{ "Spinach: Carbohydrates", 13  },
			{ "Spinach: Sugar", 48 },
			{ "Spinach: Sodium", 23  },
		};

		public static Dictionary<string, double> TomatoDictionary = new Dictionary<string, double>
		{
			{ "Tomato: Base Vitamin A", 21  },
			{ "Tomato: Base Vitamin B", 17  },
			{ "Tomato: Base Vitamin C", 33  },
			{ "Tomato: Calories", 22  },
			{ "Tomato: Total Fat", 15  },
			{ "Tomato: Protein", 26  },
			{ "Tomato: Carbohydrates", 18  },
			{ "Tomato: Sugar", 4 },
			{ "Tomato: Sodium", 32  },
		};



		// testing a dictionary transplant for two dictionaries.
		public static Dictionary<string, double> PepperDictionary = new Dictionary<string, double>
		{
			{ "Pepper: Base Vitamin A", 11  },
			{ "Pepper: Base Vitamin B", 41  },
			{ "Pepper: Base Vitamin C", 13  },
			{ "Pepper: Calories", 3  },
			{ "Pepper: Total Fat", 7  },
			{ "Pepper: Protein", 9  },
			{ "Pepper: Carbohydrates", 13  },
			{ "Pepper: Sugar", 25 },
			{ "Pepper: Sodium", 12  },
		};


		// testing a dictionary transplant for two dictionaries.
		public static Dictionary<string, double> CarrotDictionary = new Dictionary<string, double>
		{
			{ "Carrot: Base Vitamin A", 13  },
			{ "Carrot: Base Vitamin B", 32  },
			{ "Carrot: Base Vitamin C", 3  },
			{ "Carrot: Calories", 23  },
			{ "Carrot: Total Fat", 16  },
			{ "Carrot: Protein", 41  },
			{ "Carrot: Carbohydrates", 13  },
			{ "Carrot: Sugar", 5 },
			{ "Carrot: Sodium", 4  },
		};


		// testing a dictionary transplant for two dictionaries.
		public static Dictionary<string, double> PotatoDictionary = new Dictionary<string, double>
		{
			{ "Potato: Base Vitamin A", 3  },
			{ "Potato: Base Vitamin B", 7  },
			{ "Potato: Base Vitamin C", 3  },
			{ "Potato: Calories", 3  },
			{ "Potato: Total Fat", 6  },
			{ "Potato: Protein", 9  },
			{ "Potato: Carbohydrates", 3  },
			{ "Potato: Sugar", 5 },
			{ "Potato: Sodium", 2  },
		};




		// IngredientEncyclopedia Constructor (instantiate a private dictionary for each ingredient on the site (4) in this case.)
		public Ingredient()
		{
			Id = 1;

		}

	}
}