namespace Portfolio.Core.ViewModels.Project
{
    public class Permissions
    {
        public Permissions(bool isFeatured, bool hideInNavbar)
        {
            IsFeatured = isFeatured;
            HideInNavbar = hideInNavbar;
        }
        public bool IsFeatured { get; }
        public bool HideInNavbar { get; }
    }
}