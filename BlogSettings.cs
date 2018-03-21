namespace Cattronium
{
    public class BlogSettings
    {
        public string Name { get; set; } = "Cattronium";
        public string Description { get; set; } = "A place to post about my hobbies";
        public string Owner { get; set; } = "John Cattron";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
