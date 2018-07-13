using System.Collections.Generic;
using System.Linq;
using Portfolio.Core.Helpers;
using Portfolio.Core.ViewModels.Project;
using Umbraco.Web;
using Project = Portfolio.Core.Models.Project;

namespace Portfolio.Core.Controllers
{
    public class ProjectsApiController : BaseApiController
    {
       
        public ProjectListViewModel GetProjects()
        {
            var response = new ProjectListViewModel {Projects = new List<ViewModels.Project.Project>()};

            var projectCriteria = SearchHelpers.CreateContentCriteria().NodeTypeAlias("Project").Compile();
            var cachedProjects = UHelper.TypedSearch(projectCriteria).ToList();

            if (cachedProjects.Any())
            {
                foreach (var cachedProject in cachedProjects)
                {
                    var iContentProject = new Project(cachedProject);
                    response.Projects.Add(new ViewModels.Project.Project()
                    {
                        Udi =  iContentProject.GetKey(),
                        Title = iContentProject.Title,
                        Teaser = iContentProject.Teaser,
                        Description = iContentProject.Description.ToHtmlString(),
                        FeaturedImage = iContentProject.FeaturedImage.GetCropUrl(300, 300),
                        Gallery = iContentProject.Gallery.Select(image => image.GetCropUrl(1000, 1000)).ToList(),
                        LinkLabel = iContentProject.LinkLabel,
                        LinkBackgroundColor = iContentProject.LinkBackgroundColor,
                        IsLinkBackgroundTransparent = iContentProject.TransparentBackground,
                        DetailsViewTitle = iContentProject.DetailsViewTitle,
                        DetailsViewTitleBackgroundColor = iContentProject.TitleBackgroundColor,
                        IsDetailsViewTitleTransparent = iContentProject.TransparentTitleBackground
                    });
                }
            }

            return response;

        }
    }
}
