using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Portfolio.Core.Helpers;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace Portfolio.Core.Controllers
{
    public class BaseApiController : UmbracoApiController
    {
        protected static readonly JsonSerializer JsonSerializer;
        public UmbracoHelper UHelper = new UmbracoHelper(UmbracoContext.Current);
        protected static readonly JsonSerializerSettings JsonSerializerSettings =  new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Converters = new List<JsonConverter>
            {
                new IsoDateTimeConverter(),
                new StringEnumConverter { CamelCaseText = true }
            }
        };
        static BaseApiController()
        {

            JsonSerializer = new JsonSerializer
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            JsonSerializer.Converters.Add(new IsoDateTimeConverter());
            JsonSerializer.Converters.Add(new StringEnumConverter { CamelCaseText = true });

            
        }

        public IPublishedContent GetIPublishedNodeByAlias(string nodeTypeAlias)
        {
            var contentCriteria = SearchHelpers.CreateContentCriteria().NodeTypeAlias(nodeTypeAlias).Compile();
            var cachedContent = UHelper.TypedSearch(contentCriteria).FirstOrDefault();

            return cachedContent;
        }

        public List<IPublishedContent> GetIPublishedContentNodes(string nodeTypeAlias)
        {
            var contentCriteria = SearchHelpers.CreateContentCriteria().NodeTypeAlias(nodeTypeAlias).Compile();
            var cachedContent = UHelper.TypedSearch(contentCriteria).ToList();

            return cachedContent;
        }

        protected JsonResult<T> Json<T>(T content)
        {
            return Json(content, JsonSerializerSettings);
        }
     }
}