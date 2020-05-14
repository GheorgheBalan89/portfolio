namespace Portfolio.Core.ViewModels.Project
{
    public class ListDetail
    {
        public ListDetail(string webListImage, string webListPlaceholder, string mobileListImage)
        {
            WebListImage = webListImage;
            WebListPlaceholder = webListPlaceholder;
            MobileListImage = mobileListImage;
        }
        public string WebListImage { get; }
        public string WebListPlaceholder { get; }
        public string MobileListImage { get; }
    }
}