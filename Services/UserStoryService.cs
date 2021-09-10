using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserStories.Models;
using UserStories.MockData;


namespace UserStories.Services
{
    public class UserStoryService
    {
        private List<UserStory> userStories;

        public UserStoryService()
        {
            userStories = MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }

        public UserStory GetUserStory(int id)
        {
            foreach(UserStory userStory in userStories)
            {
                if (userStory.Id == id)
                    return userStory;
            }
            return null;
        }

        public UserStory DeleteUserStory(int userstoryId)
        {
            UserStory userstoryToBeDeleted = null;
            foreach (UserStory userstory in userStories)
            {
                if (userstory.Id == userstoryId)
                {
                    userstoryToBeDeleted = userstory;
                    break;
                }
            }
            if (userstoryToBeDeleted != null)
            {
                userStories.Remove(userstoryToBeDeleted);
            }
            return userstoryToBeDeleted;
        }

        public void CreateUserStory(UserStory userStory)
        {
            int NextId = 0;
            foreach (var us in userStories)
            {
                if (us.Id > NextId)
                {
                    NextId = us.Id;
                }
            }
            userStory.Id = NextId + 1;
            userStories.Add(userStory);
        }
    }
}
