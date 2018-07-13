using MealProfiler.Models;
using System.Data.Entity.Migrations;

namespace MealProfiler.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<MealProfilerContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(MealProfilerContext context)
		{
			context.Profiles.AddOrUpdate(
				p => p.ProfileId,
						new Profile { ProfileId = 1, MealGoal = 3, PrepTime = 20, MealCost = 14, MealAuthor = "Miles", SpinachQuantity = 3, TomatoQuantity = 8, SpinachCheckbox = true, TomatoCheckbox = true, Notes = "Matt Likes Programming" },
						new Profile { ProfileId = 2, MealGoal = 2, PrepTime = 15, MealCost = 3, MealAuthor = "Matt", SpinachQuantity = 2, TomatoQuantity = 4, SpinachCheckbox = true, TomatoCheckbox = true, Notes = "David Likes Programming" }

			);
		}
	}
}