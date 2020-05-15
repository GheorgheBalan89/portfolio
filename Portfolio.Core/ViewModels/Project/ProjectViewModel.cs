using System;
using System.Collections.Generic;
using System.Web;

namespace Portfolio.Core.ViewModels.Project
{
    public class ProjectViewModel
    {
        public Guid Udi { get;  }
        public string Url { get; }
        public General General { get; }
        public Detail Detail { get; }
        public Permissions Permissions { get;}
        public ListDetail ListDetail { get; }
        public List<SimilarProject> SimilarProjects { get; }

        public ProjectViewModel(Guid udi, string url, General general, Detail detail, Permissions permissions, ListDetail listDetail, List<SimilarProject> similarProjects = null)
        {
            Udi = udi;
            Url = url;
            General = general;
            Detail = detail;
            Permissions = permissions;
            ListDetail = listDetail;
            SimilarProjects = similarProjects;
        }
    }
  
}
