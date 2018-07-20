using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


// added namespace reference for my Ingredient class
using MealProfiler.Models;


namespace MealProfiler.Data
{

	// this class has a static array of initialized Ingredient objects.  Later we can assign the values to Ingredient type objects and work with them,
	// or just reference them directly by index and property.  _ingredientsRepository[0].IngredientName; for example.
	public class IngredientsRepository
	{
		// this is where I can initialize my Ingredient type/class/model array of Ingredient objects  _ingredientsRepository.
		private static Ingredient[] _ingredientsRepository = new Ingredient[]
		{

				new Ingredient()
				{  // initializer inside curly braces
					Id = 1,
					IngredientName = "Tomato",
					IngredientDescriptionHtml =
																	"Donec at nisl lacinia, convallis justo eu, suscipit urna. Aenean nibh ex, pellentesque ac magna at, venenatis vehicula massa. Nunc sodales efficitur dui eget pharetra. Cras eget facilisis lectus, eget interdum justo. Vivamus quis leo nulla. Nam porta, arcu nec feugiat pretium, odio nunc pretium leo, nec placerat urna mi nec sem. Suspendisse scelerisque nibh id consequat sodales. Maecenas sodales velit tristique, maximus felis vitae, semper felis. Phasellus tincidunt, lorem ut venenatis porta, dolor est dapibus mi, eu bibendum libero eros eget magna. In vehicula, augue faucibus gravida ornare, odio lorem molestie lacus, egestas auctor massa diam eu felis. Mauris sit amet lobortis ante, eu tristique purus. Suspendisse convallis a eros vitae accumsan. Ut mollis, sapien in malesuada laoreet, nisi sapien feugiat est, ac semper leo augue at lorem." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus.",
									
														
					
					
				},  // comma separated for multiple array objects; last object doesn't require one.

				new Ingredient()
				{  
					Id = 2,
					IngredientName = "Carrot",


					IngredientDescriptionHtml =
																	"Donec at nisl lacinia, convallis justo eu, suscipit urna. Aenean nibh ex, pellentesque ac magna at, venenatis vehicula massa. Nunc sodales efficitur dui eget pharetra. Cras eget facilisis lectus, eget interdum justo. Vivamus quis leo nulla. Nam porta, arcu nec feugiat pretium, odio nunc pretium leo, nec placerat urna mi nec sem. Suspendisse scelerisque nibh id consequat sodales. Maecenas sodales velit tristique, maximus felis vitae, semper felis. Phasellus tincidunt, lorem ut venenatis porta, dolor est dapibus mi, eu bibendum libero eros eget magna. In vehicula, augue faucibus gravida ornare, odio lorem molestie lacus, egestas auctor massa diam eu felis. Mauris sit amet lobortis ante, eu tristique purus. Suspendisse convallis a eros vitae accumsan. Ut mollis, sapien in malesuada laoreet, nisi sapien feugiat est, ac semper leo augue at lorem." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus.",


				},  

				new Ingredient()
				{ 
					Id = 3,
					IngredientName = "Potato",

					IngredientDescriptionHtml =
																	"Donec at nisl lacinia, convallis justo eu, suscipit urna. Aenean nibh ex, pellentesque ac magna at, venenatis vehicula massa. Nunc sodales efficitur dui eget pharetra. Cras eget facilisis lectus, eget interdum justo. Vivamus quis leo nulla. Nam porta, arcu nec feugiat pretium, odio nunc pretium leo, nec placerat urna mi nec sem. Suspendisse scelerisque nibh id consequat sodales. Maecenas sodales velit tristique, maximus felis vitae, semper felis. Phasellus tincidunt, lorem ut venenatis porta, dolor est dapibus mi, eu bibendum libero eros eget magna. In vehicula, augue faucibus gravida ornare, odio lorem molestie lacus, egestas auctor massa diam eu felis. Mauris sit amet lobortis ante, eu tristique purus. Suspendisse convallis a eros vitae accumsan. Ut mollis, sapien in malesuada laoreet, nisi sapien feugiat est, ac semper leo augue at lorem." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus.",

				},  

				new Ingredient()
				{  
					Id = 4,
					IngredientName = "Pepper",
					IngredientDescriptionHtml =
																	"Donec at nisl lacinia, convallis justo eu, suscipit urna. Aenean nibh ex, pellentesque ac magna at, venenatis vehicula massa. Nunc sodales efficitur dui eget pharetra. Cras eget facilisis lectus, eget interdum justo. Vivamus quis leo nulla. Nam porta, arcu nec feugiat pretium, odio nunc pretium leo, nec placerat urna mi nec sem. Suspendisse scelerisque nibh id consequat sodales. Maecenas sodales velit tristique, maximus felis vitae, semper felis. Phasellus tincidunt, lorem ut venenatis porta, dolor est dapibus mi, eu bibendum libero eros eget magna. In vehicula, augue faucibus gravida ornare, odio lorem molestie lacus, egestas auctor massa diam eu felis. Mauris sit amet lobortis ante, eu tristique purus. Suspendisse convallis a eros vitae accumsan. Ut mollis, sapien in malesuada laoreet, nisi sapien feugiat est, ac semper leo augue at lorem." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus.",

				}, 

					new Ingredient()
				{  
					Id = 5,
					IngredientName = "Spinach",
					IngredientDescriptionHtml =
																	"Donec at nisl lacinia, convallis justo eu, suscipit urna. Aenean nibh ex, pellentesque ac magna at, venenatis vehicula massa. Nunc sodales efficitur dui eget pharetra. Cras eget facilisis lectus, eget interdum justo. Vivamus quis leo nulla. Nam porta, arcu nec feugiat pretium, odio nunc pretium leo, nec placerat urna mi nec sem. Suspendisse scelerisque nibh id consequat sodales. Maecenas sodales velit tristique, maximus felis vitae, semper felis. Phasellus tincidunt, lorem ut venenatis porta, dolor est dapibus mi, eu bibendum libero eros eget magna. In vehicula, augue faucibus gravida ornare, odio lorem molestie lacus, egestas auctor massa diam eu felis. Mauris sit amet lobortis ante, eu tristique purus. Suspendisse convallis a eros vitae accumsan. Ut mollis, sapien in malesuada laoreet, nisi sapien feugiat est, ac semper leo augue at lorem." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus." +
																	"Nulla facilisi. Donec et purus aliquam, lobortis mauris non, egestas tellus. Proin in rutrum enim, sed cursus ipsum. Donec sollicitudin odio imperdiet, porta arcu quis, venenatis lorem. Sed suscipit pharetra neque, sed dignissim lorem sodales at. Nam maximus, libero at vestibulum suscipit, diam risus tristique tortor, nec dignissim ex massa non metus. Aenean bibendum euismod fermentum. Proin nec ultricies nisi. Nunc ligula ligula, eleifend tempus porta ac, feugiat non quam. Morbi posuere arcu ac tortor malesuada ornare. In diam mauris, convallis sit amet leo ut, dictum pulvinar ligula. Nunc quis mauris posuere, egestas eros non, interdum sapien. Morbi vel risus tristique ex luctus faucibus a consequat tellus. Aenean blandit finibus luctus. Proin id convallis mi, ac bibendum lacus.",

				}, 
		};

		public Ingredient[] ingredients { get => _ingredientsRepository; set => _ingredientsRepository = value; }


		// adding a GetIngredients() method that returns an array of Ingredients.  (List)
		public Ingredient[] GetIngredients()
		{
			return ingredients;
		}

		//  create a method that returns a static array Ingredient[] of instantiated Ingredient model instances (model/type/class)
		//  public  Ingredient GetIngredient()   add an id parameter so that we can return a specific Ingredient if we know its id.
		//  our Ingredient class is being referenced in a different namespace, so we need to include a using directive for it; 
		//  we need to include a 'using' directive for the 'MealProfiler.Models' namespace


		// this method returns an Ingredient object from an array of _Ingredients
		public Ingredient GetIngredient(int id)
		{
			// initial value is null, 
			Ingredient returnedIngredient = null;

			foreach (var ingredient in ingredients)
			{
				if (ingredient.Id == id)
				{
					returnedIngredient = ingredient;
					break;
				}
			}
		  // return an ingredient based on the id passed in, so that we can display on the IngredientGallery View, and IngredientDetail View.
			return returnedIngredient;
		}



	}
}