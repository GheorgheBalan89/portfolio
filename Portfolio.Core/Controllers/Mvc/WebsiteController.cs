using System.Web.Mvc;
using Portfolio.Core.Models;
using Portfolio.Core.ViewModels.Mvc;
using Umbraco.Web.Models;

namespace Portfolio.Core.Controllers.Mvc
{
    public class WebsiteController : PageController
    {
        // GET
        public override ActionResult Index(RenderModel model)
        {
            PageViewModel vm = new PageViewModel();
            Website website = new Website(model.Content);
            vm.SiteName = website.Name;

            return View("Pages/FrontPage", vm);
        }
    }
}