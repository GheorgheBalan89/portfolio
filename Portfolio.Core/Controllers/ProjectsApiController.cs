using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Archetype.Models;
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

            var site = GetIPublishedContentNodes(Website.ModelTypeAlias).FirstOrDefault(x => x.Name.ToLower().Contains(website.ToLower()));
            var iProjectList = new ProjectList(site?.Children.FirstOrDefault(x => x.DocumentTypeAlias.Contains("ProjectList")));

            response.Heading1 = iProjectList.Heading1;
            response.Heading2 = iProjectList.Heading2;

            return Ok(response);

        }

        public IHttpActionResult GetFeaturedProjects(string website)
        {
            var response = new ProjectListViewModel()
            {
                Projects = new List<ProjectViewModel>()
            };
            var projects = GetProjectsInternal(website, true);

            var featured = projects.Where(x => x.IsFeatured).Take(3);
            response.Projects = featured.ToList();
            return Ok(response);
        }

        
        private List<ProjectViewModel> GetProjectsInternal(string website, bool onlyFeatured = false)
        {
            var response = new List<ProjectViewModel>();
            var site = GetIPublishedContentNodes(Website.ModelTypeAlias).FirstOrDefault(x => x.Name.ToLower().Contains(website.ToLower()));

            var projectListPage = site?.Children.FirstOrDefault(x => x.Name.Contains("Projects"));
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

            return response;
        }

        private static ProjectViewModel IPubishedContentToPvm(IPublishedContent cachedProject)
        {
            var helper = new Umbraco.Web.UmbracoHelper(UmbracoContext.Current);
            //var publishedMedia = helper.TypedMedia(id);

            var iContentProject = new Project(cachedProject);

            var pvm = new ProjectViewModel()
            {
                Udi = iContentProject.GetKey(),
                Title = iContentProject.Title,
                Teaser = iContentProject.Teaser,

                FeaturedImage = iContentProject.FeaturedImage != null
                    ? iContentProject.FeaturedImage.FirstOrDefault().GetCropUrl(600, 413)
                    : "",
                //Gallery = iContentProject.Gallery?.Select(image => image.GetCropUrl(1000, 1000)).ToList(),
                LinkLabel = iContentProject.LinkLabel,
                LinkBackgroundColor = iContentProject.LinkBackgroundColor,
                IsLinkBackgroundTransparent = iContentProject.TransparentBackground,
                DetailsViewTitle = iContentProject.DetailsViewTitle,
                DetailsViewTitleBackgroundColor = iContentProject.TitleBackgroundColor,
                IsDetailsViewTitleTransparent = iContentProject.TransparentTitleBackground,
                Url = iContentProject.Url,
                IsFeatured = iContentProject.Featured,
                Details = new List<ProjectDetailsViewModel>()
            };

            foreach (var item in iContentProject.DetailList)
            {
              var itm = new ProjectDetailsViewModel()
              {
                  Heading = item.GetValue<string>("Heading"),
                  RichText = item.GetValue<string>("richText"),
                  MediaItem = item.GetValue<IPublishedContent>("mediaItem") != null ? 
                              item.GetValue<IPublishedContent>("mediaItem").GetCropUrl(520, 350)  :""
              };
                pvm.Details.Add(itm);           
    
            }
          
         

            return pvm;
        }
    }
}
