using Microsoft.AspNetCore.Mvc;
using YourProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace YourProjectName.Controllers
{
    public class BlogController : Controller
    {
        // Mock list of blog posts
        private static List<Post> _posts = new List<Post>
        {
            new Post { Id = 1, Title = "Introduction to MVC", Content = "MVC separates application logic from the UI.", Author = "Alice" },
            new Post { Id = 2, Title = "Learning C#", Content = "C# is a versatile and powerful language.", Author = "Bob" },
            new Post { Id = 3, Title = "Understanding Routing", Content = "Routing maps URLs to specific controllers and actions.", Author = "Charlie" }
        };

        // Action for /Blog
        public IActionResult Index()
        {
            // Pass the list of posts to the view
            return View(_posts); 
        }

        // Action for /Blog/Details/{id}
        public IActionResult Details(int id)
        {
            // Find the post matching the ID
            var post = _posts.FirstOrDefault(p => p.Id == id);
            
            // Return 404 if not found
            if (post == null)
            {
                return NotFound();
            }

            // Pass the single post to the view
            return View(post);
        }
    }
}