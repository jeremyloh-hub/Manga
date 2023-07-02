namespace Domain
{
    public class Manga
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Picture { get; set; }
        public string Status { get; set; }
        public int Chapters { get; set; }
        public int Volumes { get; set; }
    }
}
