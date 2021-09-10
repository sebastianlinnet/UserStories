using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStories.Models
{
    public class UserStory
    {
        private static int nextID = 0;
        private int NextId { get { return nextID++; } }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BusinessValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int Priority { get; set; }
        public string StoryPoints { get; set; }

        public UserStory(string title, string description, int businessvalue, DateTime creationdate, int priority, string storypoints)
        {
            Id = NextId;
            Title = title;
            Description = description;
            BusinessValue = businessvalue;
            CreationDate = creationdate;
            Priority = priority;
            StoryPoints = storypoints;
        }

        public UserStory()
        {
            
        }
    }
}
