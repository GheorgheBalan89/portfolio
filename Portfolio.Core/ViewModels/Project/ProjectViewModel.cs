using System;
using System.Collections.Generic;
using System.Web;

namespace Portfolio.Core.ViewModels.Project
{
    public class ProjectViewModel
    {
        public Guid Udi { get; set; }
        public string Title { get; set; }
        public string Teaser { get; set; }
        public string FeaturedImage { get; set; }
        public List<ProjectDetailsViewModel> Details{ get; set; }
        public string Hero { get; set; }
        public string ClientName { get; set; }
        public string Year { get; set; }
        public string Role { get; set; }
        public  string Description { get; set; }
        public bool IsFeatured { get; set; }
        public string Url { get; set; }
    }
}
