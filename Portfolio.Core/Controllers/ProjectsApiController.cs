﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Archetype.Models;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.Helpers;
using Portfolio.Core.Models;
using Portfolio.Core.Security;
using Portfolio.Core.ViewModels.Project;
using Umbraco.Core.Models;
using Umbraco.Web;
using Project = Portfolio.Core.Models.Project;

namespace Portfolio.Core.Controllers
{
    public class ProjectsApiController : BaseApiController
    {
        readonly UmbracoHelper UHelper = new UmbracoHelper(UmbracoContext.Current);

        public IHttpActionResult GetProject(string projectId)
        {
            Guid.TryParse(projectId, out Guid uuidProjectId);
            var project = UHelper.TypedContent(uuidProjectId);

            if (project != null)
            {
              return Ok(IPubishedContentToPvm(project));
            }

            return NotFound();
        }

        //[BasicAuthentication]
        public IHttpActionResult GetProjects(string website)
        {
            var site = GetIPublishedContentNodes(Website.ModelTypeAlias).FirstOrDefault(x => x.Name.ToLower().Contains(website.ToLower()));
            if (site != null)
            {
                var iProjectList = new ProjectList(site?.Children.FirstOrDefault(x => x.DocumentTypeAlias.Contains("ProjectList")));

                var response = new ProjectListViewModel(iProjectList.Heading1,
                    iProjectList.Heading2,
                    iProjectList.ParallaxBackground?.GetCropUrl(4272, 2848),
                    GetProjectsInternal(website));
                return Ok(response);

            }

            return NotFound() ;
        }

        private List<ProjectViewModel> GetProjectsInternal(string website, bool onlyFeatured = false)
        {
            var response = new List<ProjectViewModel>();
            var site = GetIPublishedContentNodes(Website.ModelTypeAlias).FirstOrDefault(x => x.Name.ToLower().Contains(website.ToLower()));

            var projectListPage = site?.Children.FirstOrDefault(x => x.DocumentTypeAlias.Contains(nameof(ProjectList)));
            if (projectListPage != null)
            {
                var projectCriteria = SearchHelpers.CreateContentCriteria().NodeTypeAlias(Project.ModelTypeAlias).And().ParentId(projectListPage.Id).Compile();
                var cachedProjects = onlyFeatured ? UHelper.TypedSearch(projectCriteria).Take(4).OrderBy(x => x.Name).ToList()
                    : UHelper.TypedSearch(projectCriteria).OrderBy(x => x.Name).ToList();

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

        private ProjectViewModel IPubishedContentToPvm(IPublishedContent cachedProject)
        {

            var iContentProject = new Project(cachedProject);

            var general = new General(iContentProject.Sort, iContentProject.Title, iContentProject.Teaser, iContentProject.Description.ToHtmlString(), iContentProject.FeaturedImage?.FirstOrDefault().GetCropUrl(600, 413));
            
            var projectDetails = iContentProject.DetailList.Select(x => new ProjectDetailsViewModel()
            {
                Heading = x.GetValue<string>(nameof(ProjectDetailsViewModel.Heading)),
                RichText = x.GetValue<string>(nameof(ProjectDetailsViewModel.RichText)),
                MediaItem = x.GetValue<IPublishedContent>("mediaItem") != null ?
                    x.GetValue<IPublishedContent>("mediaItem").Url : "",
                VideoUrl = x.GetValue<string>(nameof(ProjectDetailsViewModel.VideoUrl))
            }).ToList();
            
            var detail = new Detail(projectDetails, iContentProject.Hero?.GetCropUrl(4272, 2848), iContentProject.ClientName, iContentProject.Year, iContentProject.Role);
            var permissions = new Permissions(iContentProject.Featured, iContentProject.HideInNavbar);
            var listDetail = new ListDetail(iContentProject.WebListImage?.GetCropUrl(624, 413),
                iContentProject.WebListPlaceholder?.GetCropUrl(624,413),
                iContentProject.MobileListImage?.GetCropUrl(278,284));
            
           List<SimilarProject> similarProjects = new List<SimilarProject>();

            if (iContentProject.RelatedProject.Count() > 0)
            {
                similarProjects.AddRange(iContentProject.RelatedProject.
                    Select(related => 
                        new Project(related))
                        .Select(proj => new SimilarProject(proj.GetKey(), 
                                                            proj.WebListImage?.GetCropUrl(624, 413), 
                                                            proj.MobileListImage?.GetCropUrl(278, 284), 
                                                            proj.Title)));
            }

            var pvm = new ProjectViewModel(iContentProject.GetKey(),
                iContentProject.Url, 
                general,
                detail,
                permissions,
                listDetail,
                similarProjects
                );
         
            return pvm;
        }
    }
}
