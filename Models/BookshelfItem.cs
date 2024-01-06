namespace gutenberg.Models
{
    public class BookshelfItem
    {
        public int Id { get; set; }
        public int GutenbergID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ReadLink { get; set; }
        // Add other properties as needed
    }
}
