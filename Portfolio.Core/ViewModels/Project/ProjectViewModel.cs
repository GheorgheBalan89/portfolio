using System;
using System.Collections.Generic;

namespace Portfolio.Core.ViewModels.Project
{
    public class ProjectViewModel
    {
        public Guid Udi { get; set; }
        public string Title { get; set; }
        public string Teaser { get; set; }
        public string FeaturedImage { get; set; }
        public string Description { get; set; }
        public List<string> Gallery { get; set; }
        public string LinkLabel { get; set; }
        public string LinkBackgroundColor { get; set; }
        public bool IsLinkBackgroundTransparent{ get; set; }
        public string DetailsViewTitle { get; set; }
        public string DetailsViewTitleBackgroundColor { get; set; }
        public bool IsDetailsViewTitleTransparent { get; set; }
        public string Url { get; set; }
    }
}
