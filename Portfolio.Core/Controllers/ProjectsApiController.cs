using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Portfolio.Core.Helpers;
using Portfolio.Core.Models;
using Portfolio.Core.ViewModels.Project;
using Umbraco.Core.Models;
using Umbraco.Web;
using Project = Portfolio.Core.Models.Project;

namespace Portfolio.Core.Controllers
{
    public class ProjectsApiController : BaseApiController
    {
        public IHttpActionResult GetProject(string projectId)
        {
            var pvm = new ProjectViewModel();
            Guid.TryParse(projectId, out Guid uuidProjectId);

            var project = UHelper.TypedContent(uuidProjectId);

            if (project != null)
            {
                pvm = IPubishedContentToPvm(project);
            }

            return Ok(pvm);
        }

        public IHttpActionResult GetProjects(string website)
        {
            var response = new ProjectListViewModel {Projects = new List<ProjectViewModel>()};
            response.Projects = GetProjectsInternal(website);

            return Ok(response);

        }

        public IHttpActionResult GetFeaturedProjects(string website)
        {
            var response = new ProjectListViewModel()
            {
                Projects = new List<ProjectViewModel>()
            };
            response.Projects = GetProjectsInternal(website, true);
            return Ok(response);
        }

        
        private List<ProjectViewModel> GetProjectsInternal(string website, bool onlyFeatured = false)
        {
            var response = new List<ProjectViewModel>();
            
            var site = GetIPublishedContentNodes(Website.ModelTypeAlias).FirstOrDefault(x => x.Name.ToLower().Contains(website.ToLower()));
            
            if (site != null)
            {
                var projectListPage = site.Children.FirstOrDefault(x => x.Name.Contains("Projects"));
                if (projectListPage != null)
                {
                    var projectCriteria = SearchHelpers.CreateContentCriteria().NodeTypeAlias(Project.ModelTypeAlias).And().ParentId(projectListPage.Id).Compile();
                    var cachedProjects = onlyFeatured ? UHelper.TypedSearch(projectCriteria).Take(4).ToList()
                        : UHelper.TypedSearch(projectCriteria).ToList();

                    if (cachedProjects.Any())
                    {
                        foreach (var cachedProject in cachedProjects)
                        {
                            var pvm = IPubishedContentToPvm(cachedProject);
                            response.Add(pvm);
                        }
                    }
                }

            }
      

            return response;
        }

        private static ProjectViewModel IPubishedContentToPvm(IPublishedContent cachedProject)
        {
            var iContentProject = new Project(cachedProject);

            var pvm = new ProjectViewModel()
            {
                Udi = iContentProject.GetKey(),
                Title = iContentProject.Title,
                Teaser = iContentProject.Teaser,
                Description = iContentProject.Description.ToHtmlString(),
                FeaturedImage = iContentProject.FeaturedImage != null
                    ? iContentProject.FeaturedImage.FirstOrDefault().GetCropUrl(600, 413)
                    : "",
                Gallery = iContentProject.Gallery?.Select(image => image.GetCropUrl(1000, 1000)).ToList(),
                LinkLabel = iContentProject.LinkLabel,
                LinkBackgroundColor = iContentProject.LinkBackgroundColor,
                IsLinkBackgroundTransparent = iContentProject.TransparentBackground,
                DetailsViewTitle = iContentProject.DetailsViewTitle,
                DetailsViewTitleBackgroundColor = iContentProject.TitleBackgroundColor,
                IsDetailsViewTitleTransparent = iContentProject.TransparentTitleBackground,
                Url = iContentProject.Url
            };
            return pvm;
        }
    }
}
