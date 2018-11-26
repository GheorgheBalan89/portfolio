using System.Collections.Generic;


namespace Portfolio.Core.ViewModels.Project
{
    public class ProjectListViewModel
    {
        public string Heading1 { get; set; }
        public string Heading2 { get; set; }
        public List<ProjectViewModel> Projects{ get; set; }
    }
}
