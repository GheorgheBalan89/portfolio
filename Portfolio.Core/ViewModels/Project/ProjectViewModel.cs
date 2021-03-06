﻿using System;
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
        public List<ContentRowViewModel> ContentRows { get;  }
        public Permissions Permissions { get;}
        public ListDetail ListDetail { get; }
        public List<SimilarProject> SimilarProjects { get; }

        
        public ProjectViewModel(Guid udi, string url, General general, Detail detail, Permissions permissions, ListDetail listDetail, List<ContentRowViewModel> contentRows, List<SimilarProject> similarProjects)
        {
            Udi = udi;
            Url = url;
            General = general;
            Detail = detail;
            Permissions = permissions;
            ListDetail = listDetail;
            ContentRows = contentRows;
            SimilarProjects = similarProjects;
        }
    }
  
}
