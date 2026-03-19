using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Controllers
{
    public class BlogController : Controller
    {
        // Mock list of blog posts
        private static List<Post> _posts = new List<Post>
        {
            new Post { Id = 1, Title = "Beginner's Guide to Sucess" , 
                Content = "Success is achieved through small, consistent efforts over time.By setting clear goals, building good habits, and learning from failures, beginners can gradually improve and reach their desired outcomes.", 
                Author = "Juan Dela Cruz" },
            new Post { Id = 2, Title = "The Truth About Life", 
                Content = "Life is unpredictable and not always easy. It involves both success and failure, joy and struggle, but growth comes from how you handle these experiences and continue moving forward.", 
                Author = "Bob Uy" },
            new Post { Id = 3, Title = "8 Reasons Why Studying Is Important", 
                Content = "Studying is important because it helps you gain knowledge, develop critical thinking, and build skills needed for your future. It also improves discipline, boosts confidence, and opens more opportunities for personal and career growth.", 
                Author = "Charlie Chaplin" }
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