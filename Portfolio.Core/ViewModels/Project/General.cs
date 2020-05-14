namespace Portfolio.Core.ViewModels.Project
{
    public class General
    {
        public General(long sort, string title, string teaser, string description, string featuredImage)
        {
            Sort = sort;
            Title = title;
            Teaser = teaser;
            Description = description;
            FeaturedImage = featuredImage;
        }
        public long Sort { get; }
        public string Title { get; }
        public string Teaser { get; }
        public string Description { get; }
        public string FeaturedImage { get; }
    }
}