using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new IndexViewModel
        {
            WelcomeMessage = "Welcome to the Leptube when is all about you",
            LearnLink = "https://www.netflix.com/my-en/",
            LearnLinkText = "Show time",
            YouTubeLinks = new List<string>
            {
                "https://www.youtube.com/embed/dQw4w9WgXcQ", // Example video 1
                "https://www.youtube.com/embed/9bZkp7q19f0", // Example video 2
                "https://www.youtube.com/embed/V-_O7nl0Ii0", // Example video 3
                "https://www.youtube.com/embed/ZZ5LpwO-An4", // Example video 4
                "https://www.youtube.com/embed/hTWKbfoikeg", // Example video 5
                "https://www.youtube.com/embed/kJQP7kiw5Fk"  // Example video 6
            }
        };

        return View(model);
    }
}