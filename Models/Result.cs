namespace gutenberg.Models
{
    public class Result
    {
        public int id { get; set; }
        public string title { get; set; }
        public List<Author> authors { get; set; }
        public Formats formats { get; set; }
    }
}
