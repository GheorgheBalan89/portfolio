using System.Collections.Generic;
using Portfolio.Core.Models;
using Umbraco.Core.Models;


namespace Portfolio.Core.ViewModels.Project
{
    public class ProjectListViewModel 
    {
        public string Heading1 { get; }
        public string Heading2 { get;  }
        public string ParallaxBackground { get; }
        public List<ProjectViewModel> Projects{ get; }

        public ProjectListViewModel(string heading1, string heading2, string parallaxBg, List<ProjectViewModel> projects)
        {
            Heading1 = heading1;
            Heading2 = heading2;
            ParallaxBackground = parallaxBg;
            Projects = projects;
        }
    }
}
