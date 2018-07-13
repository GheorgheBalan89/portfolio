using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace Portfolio.Core.Controllers
{
    public class BaseApiController : UmbracoApiController
    {
        protected static readonly JsonSerializer JsonSerializer;
        public UmbracoHelper UHelper = new UmbracoHelper(UmbracoContext.Current);

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
    }
}