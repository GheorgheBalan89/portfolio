using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Portfolio.Core.Models;
using Portfolio.Core.ViewModels.Employment;
using Portfolio.Core.ViewModels.Intro;
using Portfolio.Core.ViewModels.Skill;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Portfolio.Core.Controllers
{
    public class ContentApiController : BaseApiController
    {
        public IHttpActionResult GetIntro()
        {
            var intro = new IntroViewModel();
            var node = GetIPublishedNodeByAlias(Models.Website.ModelTypeAlias);

            if (node != null)
            {
                var websiteNode = new Website(node);
                intro.AboutText = websiteNode.AboutText.ToHtmlString();
                intro.ProfileImage = websiteNode.ProfilePicture != null? websiteNode.ProfilePicture.GetCropUrl(200, 300) : "";
                intro.Cv = websiteNode.File;
            }

            return Ok(intro);
        }

        public IHttpActionResult GetSkills()
        {
            var skills = new List<SkillViewModel>();

            var cachedContentNode = GetIPublishedNodeByAlias(Models.ContentPage.ModelTypeAlias);

            if (cachedContentNode != null)
            {
                var content = new Models.ContentPage(cachedContentNode);
                if (content.Skills.Any())
                {
                    foreach (var skill in content.Skills)
                    {
                        skills.Add(
                            new SkillViewModel()
                            {
                                Name = skill.GetValue("Name"),
                                Value = skill.GetValue("Value")
                            }
                        );
                    }
                }
            }

            return Ok(skills);
        }

        public IHttpActionResult GetEmployments()
        {
            var employments = new List<EmploymentViewModel>();

            var cachedContentNode = GetIPublishedNodeByAlias(Models.ContentPage.ModelTypeAlias);

            if (cachedContentNode != null)
            {
                var content = new Models.ContentPage(cachedContentNode);
                if (content.Experience.Any())
                {
                    foreach (var employment in content.Experience)
                    {
                        employments.Add(
                            new EmploymentViewModel()
                            {
                                Name = employment.GetValue("EmploymentName"),
                                StartDate = new DateTime(),
                                EndDate = new DateTime(),
                                Description = employment.GetValue("Description"),
                                Employer = employment.GetValue("Employer"),
                                EmployerLogo = employment.GetValue("EmployerLogo"),
                                EmployerUrl = employment.GetValue("EmployerUrl")
                            }
                        );
                    }
                }
            }


            return Ok(employments);
        }

        public IHttpActionResult GetNavigation(string websiteName)
        {

            var site = GetIPublishedContentNodes(Website.ModelTypeAlias).FirstOrDefault( x => x.Name.ToLower().Contains(websiteName.ToLower()));
            var navigation = GetNavElements(site);
            
            return Ok(navigation);
        }

        private static List<NavigationItem> GetNavElements(IPublishedContent node)
        {
            List<NavigationItem> navigation = new List<NavigationItem>();
            foreach (var child in node.Children)
            {
                var visible = child.GetProperty("hideInNavbar").Value.ToString();
                
                var navItem = new NavigationItem()
                {
                    Label = child.Name,
                    IsPublished = child.IsVisible(),
                    IsHidden = Convert.ToBoolean(visible),
                    Url = child.Url
                };
                
                if (child.Children.ToList().Count > 0)
                {
                    navItem.Children =  GetNavElements(child);
                }
                navigation.Add(navItem);
            }

            return navigation;
        }
    }
}