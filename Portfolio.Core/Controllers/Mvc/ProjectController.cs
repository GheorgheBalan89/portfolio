using Microsoft.AspNetCore.Mvc;
using Portfolio.Core.ViewModels.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;
using ActionResult = System.Web.Mvc.ActionResult;


namespace Portfolio.Core.Controllers.Mvc
{
    public class ProjectController : PageController
    {
      
        public override ActionResult Index(RenderModel model)
        {
            PageViewModel vm = new PageViewModel
            {
                ProjectId = model.Content.GetKey().ToString()
            };

            return View("Pages/Project", vm);
        }
    }
}
