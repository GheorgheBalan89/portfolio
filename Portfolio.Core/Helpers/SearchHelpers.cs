using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq;
using System.Linq.Expressions;
using Examine;
using Examine.Providers;
using Examine.SearchCriteria;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Portfolio.Core.Helpers
{
    public class SearchHelpers
    {
        //private static readonly BaseSearchProvider MemberSearchProvider;

        //static SearchHelpers()
        //{
        //    MemberSearchProvider = ExamineManager.Instance.SearchProviderCollection["InternalMemberSearcher"];
        //}

        public static ISearchCriteria CreateContentCriteria()
        {
            return ExamineManager.Instance.CreateSearchCriteria("content");
        }

        public static ISearchCriteria CreateMediaCriteria()
        {
            return ExamineManager.Instance.CreateSearchCriteria("media");
        }

        public static ISearchCriteria CreateMemberCriteria()
        {
            return ExamineManager.Instance.CreateSearchCriteria("member");
        }
    }
}
