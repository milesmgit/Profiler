using System.Collections.Generic;

namespace MealProfiler.Models
{
	public class ProfileListViewModel
	{
		public List<ProfileViewModel> Profiles { get; set; }

		// this represents the total number of meal profiles
		public int TotalProfiles { get; set; }
	}
}