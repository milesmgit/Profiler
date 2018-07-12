using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using MealProfiler.Models;
using MealProfiler.Data;



namespace MealProfiler.Controllers
{

	public class ProfileController : Controller
	{

		private IngredientsRepository _ingredientsRepository = null;


		// constructor for the MattController that calls the MealProfile() Class and assigns it 
		// to the private variable _mealProfiles      and again for _mealProfilesRepository
		public ProfileController()
		{
			_ingredientsRepository = new IngredientsRepository();
		}



		public static List<Profile> Profiles = new List<Profile>
		{
						new Profile { ProfileId = 1, MealGoal = 3, PrepTime = 20, MealCost = 14, MealAuthor = "Miles", SpinachQuantity = 3, TomatoQuantity = 8, SpinachCheckbox = true, TomatoCheckbox = true, Notes = "Matt Likes Programming" },
						new Profile { ProfileId = 2, MealGoal = 2, PrepTime = 15, MealCost = 3, MealAuthor = "Matt", SpinachQuantity = 2, TomatoQuantity = 4, SpinachCheckbox = true, TomatoCheckbox = true, Notes = "David Likes Programming" }
		};

		public ActionResult Index()
		{
			var profileList = new ProfileListViewModel
			{
				//Convert each Profile to a ProfileViewModel
				Profiles = Profiles.Select(p => new ProfileViewModel
				{
					ProfileId = p.ProfileId,
					MealGoal = p.MealGoal,
					PrepTime = p.PrepTime,
					MealCost = p.MealCost,
					MealAuthor = p.MealAuthor,
					SpinachQuantity = p.SpinachQuantity,
					TomatoQuantity = p.TomatoQuantity,
					SpinachCheckbox = p.SpinachCheckbox,
					TomatoCheckbox = p.TomatoCheckbox,
					Notes = p.Notes
				}).ToList()
			};

			profileList.TotalProfiles = profileList.Profiles.Count;

			return View(profileList);
		}



		public ActionResult ProfileDetail(int id)
		{
			var profile = Profiles.SingleOrDefault(p => p.ProfileId == id);
			if (profile != null)
			{
				var profileViewModel = new ProfileViewModel
				{
					ProfileId = profile.ProfileId,
					MealGoal = profile.MealGoal,
					PrepTime = profile.PrepTime,
					MealCost = profile.MealCost,
					MealAuthor = profile.MealAuthor,
					SpinachQuantity = profile.SpinachQuantity,
					TomatoQuantity = profile.TomatoQuantity,
					SpinachCheckbox = profile.SpinachCheckbox,
					TomatoCheckbox = profile.TomatoCheckbox,
					Notes = profile.Notes
				
				};

				

				return View(profileViewModel);
			}

			return new HttpNotFoundResult();
		}



		// add index action method; needs to be public and return and ActionResult object
		public ActionResult IngredientGallery()
		{

			// passing a _ingredientRepository array to the ingredient variable; this will make the array available 
			// via the View's Model property.
			var ingredients = _ingredientsRepository.GetIngredients();
			return View(ingredients);


		}




		// id is returned from the address bar path at present, but after i set up clickable linked images
		// then the ingredient id will be set up that way.
		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			// i initialized in the ingredient constructor an Id = 1;
			// i used .Value to cast the int? to int.  could have casted explicitly also.
			var ingredient = _ingredientsRepository.GetIngredient(id.Value);


			ViewBag.DictionaryType = Ingredient.TomatoDictionary;

			return View(ingredient);

		}



		public ActionResult ProfileAdd()
		{
			var profileViewModel = new ProfileViewModel();

			// this will add the list of our meals enum to the dropdownfor: so in the future, don't manually add them to a dropdown form element.  use the DropDownFor method as seen here. along with the enum.
			ViewBag.MealsSelectListItems = new SelectList(
				Data.Data.Meals, "Id", "Name");

			return View("AddEditProfile", profileViewModel);
		}


		[HttpPost]
		public ActionResult AddProfile(ProfileViewModel profileViewModel)
		{
				var nextProfileId = Profiles.Max(p => p.ProfileId) + 1;

				var profile = new Profile
				{
					ProfileId = nextProfileId,
					MealGoal = profileViewModel.MealGoal,
					PrepTime = profileViewModel.PrepTime,
					MealCost = profileViewModel.MealCost,
					MealAuthor = profileViewModel.MealAuthor,
					SpinachQuantity = profileViewModel.SpinachQuantity,
					TomatoQuantity = profileViewModel.TomatoQuantity,
					SpinachCheckbox = profileViewModel.SpinachCheckbox,
					TomatoCheckbox = profileViewModel.TomatoCheckbox,
					Notes = profileViewModel.Notes
				};

				Profiles.Add(profile);

			return RedirectToAction("Index");
			
		}





	}




}





