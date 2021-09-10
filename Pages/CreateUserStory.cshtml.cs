using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserStories.Models;
using UserStories.MockData;
using UserStories.Services;

namespace UserStories.Pages
{
    public class CreateUserStoryModel : PageModel
    {
        [BindProperty]
        public UserStory UserStory { get; set; }

        private UserStoryService userStoryService;
        public CreateUserStoryModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public IActionResult OnPost()
        {
            userStoryService.CreateUserStory(UserStory);
            UserStory.CreationDate = DateTime.Today;
            return RedirectToPage("UserStories");
        }
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
