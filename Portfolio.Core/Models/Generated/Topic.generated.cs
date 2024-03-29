//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Portfolio.Core.Models
{
	/// <summary>Topic</summary>
	[PublishedContentModel("topic")]
	public partial class Topic : PublishedContentModel, IProject
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "topic";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Topic(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Topic, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Client Name
		///</summary>
		[ImplementPropertyType("clientName")]
		public string ClientName
		{
			get { return Portfolio.Core.Models.Project.GetClientName(this); }
		}

		///<summary>
		/// content
		///</summary>
		[ImplementPropertyType("content")]
		public Archetype.Models.ArchetypeModel Content
		{
			get { return Portfolio.Core.Models.Project.GetContent(this); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return Portfolio.Core.Models.Project.GetDescription(this); }
		}

		///<summary>
		/// Detail list
		///</summary>
		[ImplementPropertyType("detailList")]
		public Archetype.Models.ArchetypeModel DetailList
		{
			get { return Portfolio.Core.Models.Project.GetDetailList(this); }
		}

		///<summary>
		/// Featured
		///</summary>
		[ImplementPropertyType("featured")]
		public bool Featured
		{
			get { return Portfolio.Core.Models.Project.GetFeatured(this); }
		}

		///<summary>
		/// FeaturedImage: w: 624px x h: 413 px
		///</summary>
		[ImplementPropertyType("featuredImage")]
		public IEnumerable<IPublishedContent> FeaturedImage
		{
			get { return Portfolio.Core.Models.Project.GetFeaturedImage(this); }
		}

		///<summary>
		/// Hero: w: 4272 x 2848 px (top 60%)
		///</summary>
		[ImplementPropertyType("hero")]
		public IPublishedContent Hero
		{
			get { return Portfolio.Core.Models.Project.GetHero(this); }
		}

		///<summary>
		/// HideInNavbar
		///</summary>
		[ImplementPropertyType("hideInNavbar")]
		public bool HideInNavbar
		{
			get { return Portfolio.Core.Models.Project.GetHideInNavbar(this); }
		}

		///<summary>
		/// mobileListImage
		///</summary>
		[ImplementPropertyType("mobileListImage")]
		public IPublishedContent MobileListImage
		{
			get { return Portfolio.Core.Models.Project.GetMobileListImage(this); }
		}

		///<summary>
		/// RelatedProjects: content picker for related projects
		///</summary>
		[ImplementPropertyType("relatedProject")]
		public IEnumerable<IPublishedContent> RelatedProject
		{
			get { return Portfolio.Core.Models.Project.GetRelatedProject(this); }
		}

		///<summary>
		/// Role
		///</summary>
		[ImplementPropertyType("role")]
		public string Role
		{
			get { return Portfolio.Core.Models.Project.GetRole(this); }
		}

		///<summary>
		/// Sort: Sort order
		///</summary>
		[ImplementPropertyType("sort")]
		public int Sort
		{
			get { return Portfolio.Core.Models.Project.GetSort(this); }
		}

		///<summary>
		/// Teaser
		///</summary>
		[ImplementPropertyType("teaser")]
		public string Teaser
		{
			get { return Portfolio.Core.Models.Project.GetTeaser(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return Portfolio.Core.Models.Project.GetTitle(this); }
		}

		///<summary>
		/// webListImage: w: 624px x h: 413 px
		///</summary>
		[ImplementPropertyType("webListImage")]
		public IPublishedContent WebListImage
		{
			get { return Portfolio.Core.Models.Project.GetWebListImage(this); }
		}

		///<summary>
		/// webListPlaceholder: w: 624 px, h: 413 px
		///</summary>
		[ImplementPropertyType("webListPlaceholder")]
		public IPublishedContent WebListPlaceholder
		{
			get { return Portfolio.Core.Models.Project.GetWebListPlaceholder(this); }
		}

		///<summary>
		/// Year
		///</summary>
		[ImplementPropertyType("year")]
		public string Year
		{
			get { return Portfolio.Core.Models.Project.GetYear(this); }
		}
	}
}
