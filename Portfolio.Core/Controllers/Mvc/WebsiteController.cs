using System.Web.Mvc;
using Portfolio.Core.ViewModels.Mvc;
using Umbraco.Web.Models;

namespace Portfolio.Core.Controllers.Mvc
{
    public class WebsiteController : PageController
    {
        // GET
        public override ActionResult Index(RenderModel model)
        {
            PageViewModel vm;
            
            return View("Pages/FrontPage");
        }
    }
}