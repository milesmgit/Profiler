﻿using System;
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






		public ActionResult Index()
		{
			using (var mealProfilerContext = new MealProfilerContext())
			{
				var profileList = new ProfileListViewModel
				{
					//Convert each Person to a PersonViewModel
					Profiles = mealProfilerContext.Profiles.Select(p => new ProfileViewModel
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
		}


		public ActionResult ProfileDetail(int id)
		{
			using (var mealProfilerContext = new MealProfilerContext())
			{
				var profile = mealProfilerContext.Profiles.SingleOrDefault(p => p.ProfileId == id);
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
		public ActionResult IngredientDetail(int? id)
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
			using (var mealProfilerContext = new MealProfilerContext())
			{
				var profile = new Profile
				{
				
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

				mealProfilerContext.Profiles.Add(profile);
				mealProfilerContext.SaveChanges();
			}

			// this will add the list of our meals enum to the dropdownfor: so in the future, don't manually add them to a dropdown form element.  use the DropDownFor method as seen here. along with the enum.
			SetupMealsSelectListItems();

			return RedirectToAction("Index");
		}








		public ActionResult ProfileEdit(int id)
		{
			using (var mealProfilerContext = new MealProfilerContext())
			{
				var profile = mealProfilerContext.Profiles.SingleOrDefault(p => p.ProfileId == id);
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

					// this will add the list of our meals enum to the dropdownfor: so in the future, don't manually add them to a dropdown form element.  use the DropDownFor method as seen here. along with the enum.
					SetupMealsSelectListItems();

					return View("AddEditProfile", profileViewModel);
				}
			}

			return new HttpNotFoundResult();
		}



		[HttpPost]
		public ActionResult EditProfile(ProfileViewModel profileViewModel)
		{
			using (var mealProfilerContext = new MealProfilerContext())
			{
				var profile = mealProfilerContext.Profiles.SingleOrDefault(p => p.ProfileId == profileViewModel.ProfileId);

				if (profile != null)
				{
					profile.MealGoal = profileViewModel.MealGoal;
					profile.PrepTime = profileViewModel.PrepTime;
					profile.MealCost = profileViewModel.MealCost;
					profile.MealAuthor = profileViewModel.MealAuthor;
					profile.SpinachQuantity = profileViewModel.SpinachQuantity;
					profile.TomatoQuantity = profileViewModel.TomatoQuantity;
					profile.SpinachCheckbox = profileViewModel.SpinachCheckbox;
					profile.TomatoCheckbox = profileViewModel.TomatoCheckbox;
					profile.Notes = profileViewModel.Notes;
					mealProfilerContext.SaveChanges();


					SetupMealsSelectListItems();
					return RedirectToAction("Index");
				}
			}

			return new HttpNotFoundResult();
		}



		[HttpPost]
		public ActionResult DeleteProfile(ProfileViewModel profileViewModel)
		{
			using (var mealProfilerContext = new MealProfilerContext())
			{
				var profile = mealProfilerContext.Profiles.SingleOrDefault(p => p.ProfileId == profileViewModel.ProfileId);

				if (profile != null)
				{
					mealProfilerContext.Profiles.Remove(profile);
					mealProfilerContext.SaveChanges();

					return RedirectToAction("Index");
				}
			}

			return new HttpNotFoundResult();
		}








		private void SetupMealsSelectListItems()
		{
			ViewBag.MealsSelectListItems = new SelectList(
							Data.Data.Meals, "Id", "Name");
		}



	}




}





