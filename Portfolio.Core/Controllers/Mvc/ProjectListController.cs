using System.Web.Mvc;
using Portfolio.Core.ViewModels.Mvc;
using Umbraco.Web.Models;

namespace Portfolio.Core.Controllers.Mvc
{
    public class ProjectListController : PageController
    {
        public override ActionResult Index(RenderModel model)
        {
            PageViewModel vm = new PageViewModel();

            return View("Pages/ProjectList", vm);
        }
    }
}
