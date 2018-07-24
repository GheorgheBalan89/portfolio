using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Portfolio.Core.Helpers;
using Portfolio.Core.ViewModels.Project;
using Umbraco.Web;
using Project = Portfolio.Core.Models.Project;

namespace Portfolio.Core.Controllers
{
    public class ProjectsApiController : BaseApiController
    {
        public IHttpActionResult GetProjects()
        {
            var response = new ProjectListViewModel {Projects = new List<ProjectViewModel>()};

            var projectCriteria = SearchHelpers.CreateContentCriteria().NodeTypeAlias(Project.ModelTypeAlias).Compile();
            var cachedProjects = UHelper.TypedSearch(projectCriteria).ToList();

            if (cachedProjects.Any())
            {
                foreach (var cachedProject in cachedProjects)
                {
                    var iContentProject = new Project(cachedProject);
                    response.Projects.Add(new ProjectViewModel()
                    {
                        Udi =  iContentProject.GetKey(),
                        Title = iContentProject.Title,
                        Teaser = iContentProject.Teaser,
                        Description = iContentProject.Description.ToHtmlString(),
                        FeaturedImage = iContentProject.FeaturedImage != null ? iContentProject.FeaturedImage.GetCropUrl(300, 300) :"",
                        Gallery = iContentProject.Gallery?.Select(image => image.GetCropUrl(1000, 1000)).ToList(),
                        LinkLabel = iContentProject.LinkLabel,
                        LinkBackgroundColor = iContentProject.LinkBackgroundColor,
                        IsLinkBackgroundTransparent = iContentProject.TransparentBackground,
                        DetailsViewTitle = iContentProject.DetailsViewTitle,
                        DetailsViewTitleBackgroundColor = iContentProject.TitleBackgroundColor,
                        IsDetailsViewTitleTransparent = iContentProject.TransparentTitleBackground,
                        Url = iContentProject.Url
                    });
                }
            }

            return Ok(response);

        }
    }
}
