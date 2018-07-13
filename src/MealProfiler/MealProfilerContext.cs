using MealProfiler.Models;
using System.Data.Entity;

namespace MealProfiler
{
	public class MealProfilerContext : DbContext
	{
		public MealProfilerContext() : base("name=MealProfiler") { }

		public virtual DbSet<Profile> Profiles { get; set; }
	}
}