namespace MVC.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }    // Added '?'
        public string? Content { get; set; }  // Added '?'
        public string? Author { get; set; }   // Added '?'
    }
}