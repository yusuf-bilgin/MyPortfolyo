namespace MyPortfolyo.DAL.Entities
{
    public class SocialMedia
    {
        // Sosyal medya hesap sayisi artip azalabilir. O yuzden dinamik olacak
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
