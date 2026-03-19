using Microsoft.AspNetCore.Mvc;
using YourAppName.Models;
using System.Collections.Generic;
using System.Linq;

namespace YourAppName.Controllers
{
    public class BlogController : Controller
    {
        // Mock list of blog posts
        private static List<Post> _posts = new List<Post>
        {
            new Post { Id = 1, Title = "Getting Started with MVC", Content = "MVC stands for Model, View, and Controller. It is a great architectural pattern.", Author = "Alice" },
            new Post { Id = 2, Title = "Understanding Routing", Content = "Routing is how ASP.NET Core matches incoming URLs to controller actions.", Author = "Bob" },
            new Post { Id = 3, Title = "Mastering C#", Content = "C# is a powerful, strongly-typed language used heavily in the .NET ecosystem.", Author = "Charlie" }
        };

        // GET: /Blog/
        public IActionResult Index()
        {
            return View(_posts);
        }

        // GET: /Blog/Details/1
        public IActionResult Details(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            
            if (post == null)
            {
                return NotFound(); // Returns a 404 Not Found result if the Id doesn't exist
            }
            
            return View(post);
        }
    }
}