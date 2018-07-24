using System.Web.Mvc;
using Portfolio.Core.ViewModels.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Portfolio.Core.Controllers.Mvc
{
    public class PageController : SurfaceController, IRenderMvcController
    {
        // GET
        public virtual ActionResult Index(RenderModel model)
        {
            return View(model.Content.DocumentTypeAlias, BuildView());
        }
      

        protected T BuildView<T>() where T : PageViewModel, new()
        {
            return new T {};
        }

        protected PageViewModel BuildView()
        {
            return BuildView<PageViewModel>();
        }
        
    }
}