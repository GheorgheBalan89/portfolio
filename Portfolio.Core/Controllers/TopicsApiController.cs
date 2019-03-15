using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Portfolio.Core.Helpers;
using Portfolio.Core.Models;
using Portfolio.Core.ViewModels.Topic;
using Umbraco.Web;

namespace Portfolio.Core.Controllers
{
    public class TopicsApiController : BaseApiController
    {
        public IHttpActionResult GetTopics()
        {
            var topics = new List<TopicViewModel>();
            var topicCriteria = SearchHelpers.CreateContentCriteria().NodeTypeAlias(Topic.ModelTypeAlias).Compile();
            var cachedTopics = UHelper.TypedSearch(topicCriteria).ToList();

            if (cachedTopics.Any())
            {
                foreach (var topic in cachedTopics)
                {
                    var iTopic = new Topic(topic);
                    topics.Add(
                        new TopicViewModel()
                        {
                            Udi = iTopic.GetKey(),
                            Title = iTopic.Title,
                            Teaser = iTopic.Teaser,
                            FeaturedImage = iTopic.FeaturedImage != null ?  iTopic.FeaturedImage.FirstOrDefault().GetCropUrl(300, 300) : "",
                            LinkLabel = iTopic.LinkLabel,
                            LinkBackgroundColor = iTopic.LinkBackgroundColor,
                            IsLinkBackgroundTransparent = iTopic.TransparentBackground,
                            DetailsViewTitle = iTopic.DetailsViewTitle,
                            DetailsViewTitleBackgroundColor = iTopic.TitleBackgroundColor,
                            IsDetailsViewTitleTransparent = iTopic.TransparentTitleBackground,
                            Url = iTopic.Url
                        }
                  );

                }
            }

            return Ok(topics);
        }
    }
}