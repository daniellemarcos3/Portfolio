namespace Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public string GitHubLink { get; set; } = "";

        public string ImageUrl { get; set; } = "";
    }
}