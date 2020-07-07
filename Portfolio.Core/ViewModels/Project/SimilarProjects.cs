using System;
using System.Collections.Generic;
using umbraco.cms.helpers;

namespace Portfolio.Core.ViewModels.Project
{
    public class SimilarProject
    {
        public Guid Udi { get;  }
        public string WebListImage { get; }
        public string MobileListImage { get; }
        public string Title { get; }
        public string Url { get; }
        public SimilarProject(Guid udi, string webListImage, string mobileListImage, string title, string url)
        {
            Udi = udi;
            WebListImage = webListImage;
            MobileListImage = mobileListImage;
            Title = title;
            Url = url;
        }
    }
}