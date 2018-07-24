using Umbraco.Core.Models;
using Umbraco.Web;

namespace Portfolio.Core.ViewModels.Mvc
{
    public  class PageViewModel
    {
        public PageViewModel()
        {
            Page = UmbracoContext.Current.PublishedContentRequest.PublishedContent;
        }
        public IPublishedContent Page { get; }
    }
}
