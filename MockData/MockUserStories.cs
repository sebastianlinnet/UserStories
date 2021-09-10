using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStories.Models;

namespace UserStories.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
             new UserStory("Create Story", "As P.O I want to create a new Story So ...", 5, new DateTime(2021, 08, 14), 10, "Small"),
             new UserStory("Edit Story", "As P.O I want to edit a Story So ...", 3, new DateTime(2020, 08, 14), 3, "Medium"),
             new UserStory("Move Story", "As team member I want to move a Story So ...", 2, new DateTime(2019, 08, 14), 3, "Large"),
             new UserStory("Delete Story", "As team member I want to delete a Story So ...", 10, new DateTime(2018, 08, 14), 4, "X-Large")
        };

        public static List<UserStory> GetMockUserStories()
        {
            return userStories;
        }
    }
}
