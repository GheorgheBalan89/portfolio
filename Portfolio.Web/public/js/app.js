webpackJsonp([1],{NHnr:function(t,e,s){"use strict";Object.defineProperty(e,"__esModule",{value:!0});var i=s("7+uW"),a=s("AYPi"),n=s.n(a),r=s("mtWM"),o=s.n(r),l={name:"NavigationNerija",data:function(){return{navData:"",scrollPosition:"",isHovered:!1}},mounted:function(){var t=this;o.a.get("/umbraco/Api/ContentApi/GetNavigation/65ee23?websiteName=Nerija").then(function(e){t.navData=e.data})},methods:{menuHover:function(){this.isHovered=!0},updateScroll:function(){this.scrollPosition=Number(window.scrollY)}},created:function(){window.addEventListener("scroll",this.updateScroll)},destroy:function(){window.removeEventListener("scroll",this.updateScroll)}},c={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"navigation-container"},[s("div",[s("nav",{staticClass:"hover-underline-menu",attrs:{"data-menu-underline-from-center":""}},[t._m(0),t._v(" "),t.navData?s("ul",{staticClass:"menu align-center"},t._l(t.navData,function(e){return e.IsHidden?t._e():s("li",[(t.isHovered,s("a",{staticClass:"underline-from-center",attrs:{href:e.Url},on:{mouseover:function(e){t.menuHover()}}},[t._v(" "+t._s(e.Label)+" ")]))])})):t._e()])])])},staticRenderFns:[function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"top-bar"},[e("img",{staticClass:"header-image",attrs:{src:"/static/Avatar.png",alt:"logo"}})])}]},v=s("VU/8")(l,c,!1,null,null,null).exports,d={name:"ContentRow",props:["rows"],methods:{track:function(){var t=window.location.origin+window.location.pathname;page(t)}}},m={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",t._l(t.rows,function(e){return null!=t.rows&&null!=e?s("div",{key:e.BigHeading,staticClass:"row content-row"},[null!=e.BigHeading?s("h2",[t._v(t._s(e.BigHeading))]):t._e(),t._v(" "),null!=e.Icon?s("div",{staticClass:"grid-x"},[s("div",{staticClass:"cell medium-2 icon-container"},[null!=e.Icon?s("img",{staticClass:"icon",attrs:{src:e.Icon,alt:e.BigHeading||e.SmallHeading}}):t._e()]),t._v(" "),null!=e.TextColumnLeft?s("div",{staticClass:"cell medium-5 text"},[s("p",[t._v("\r\n                          "+t._s(e.TextColumnLeft)+"\r\n                        ")])]):t._e(),t._v(" "),e.TextColumnRight?s("div",{staticClass:"cell medium-5 text"},[s("p",[t._v("\r\n                          "+t._s(e.TextColumnRight)+"\r\n                        ")])]):t._e()]):null==e.Icon&&null!=e.SmallHeading?s("div",{staticClass:"grid-x layout-2"},[s("div",{staticClass:"cell medium-2 icon-container"},[null!=e.SmallHeading?s("h3",{staticClass:"small-heading"},[t._v(t._s(e.SmallHeading))]):t._e()]),t._v(" "),null!=e.TextColumnLeft?s("div",{staticClass:"cell medium-5 text-layout-2"},[s("p",[t._v("\r\n                          "+t._s(e.TextColumnLeft)+"\r\n                        ")])]):t._e(),t._v(" "),e.TextColumnRight?s("div",{staticClass:"cell medium-5 text-layout-2"},[s("p",[t._v("\r\n                          "+t._s(e.TextColumnRight)+"\r\n                        ")])]):t._e()]):t._e(),t._v(" "),s("div",{staticClass:"grid-x"},[s("div",{staticClass:"cell medium-12 main-image-container"},[s("img",{staticClass:"main-image",attrs:{src:e.Image,alt:e.BigHeading||e.SmallHeading}})])])]):t._e()}))},staticRenderFns:[]},u={name:"SingleProjectPage",props:["project"],methods:{track:function(){var t=window.location.origin+window.location.pathname;page(t)}},components:{ContentRow:s("VU/8")(d,m,!1,null,null,null).exports}},_={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return null!=t.project?s("div",{staticClass:"projectlist-container details-bg"},[null!=t.project.Detail?s("div",{staticClass:"hero-section"},[s("div",{staticClass:"hero-section-text"},[s("h1",{staticClass:"large-visible"},[t._v("   \n                "+t._s(t.project.General.Title)+"\n            ")]),t._v(" "),s("h2",{staticClass:"large-hidden medium-visible"},[t._v("\n                "+t._s(t.project.General.Title)+"\n            ")]),t._v(" "),s("div",{staticClass:"text-center"},[s("h5",[t._v(" Client: "+t._s(t.project.Detail.ClientName)+" \n                     "),s("br"),t._v(" Year: "+t._s(t.project.Detail.Year)+" \n                     "),s("br"),t._v(" Role: "+t._s(t.project.Detail.Role)+"\n                ")])]),t._v(" "),s("div",{staticClass:"hero-description ",domProps:{innerHTML:t._s(t.project.General.Description)}})])]):t._e(),t._v(" "),s("ContentRow",{attrs:{rows:t.project.ContentRows}})],1):t._e()},staticRenderFns:[]},p=s("VU/8")(u,_,!1,null,null,null).exports,h={name:"RelatedProjects",props:["relatedProjects"],methods:{featuredClick:function(t){window.location.href=t}}},g={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return null!=t.relatedProjects?s("div",[t._m(0),t._v(" "),s("div",{staticClass:"grid-x related-projects-container"},t._l(t.relatedProjects,function(e){return s("div",{key:e.Udi,staticClass:"cell medium-4 related-project text-center",on:{click:function(s){t.featuredClick(e.Url)}}},[s("img",{attrs:{src:e.WebListImage,alt:e.Title,width:"100%"}}),t._v(" "),s("h3",[t._v(t._s(e.Title))])])}))]):t._e()},staticRenderFns:[function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"text-center related-heading"},[e("h4",[this._v("More like this")])])}]},f=s("VU/8")(h,g,!1,null,null,null).exports,C={name:"Footer",data:function(){return{cv:"",cvText:""}},mounted:function(){var t=this;o.a.get("/umbraco/Api/ContentApi/GetResume?websiteName=Nerija").then(function(e){t.cv=e.data.Cv,t.cvText=e.data.CvText})}},j={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("footer",{staticClass:"site-footer"},[t._m(0),t._v(" "),s("div",{staticClass:"grid-container"},[s("div",{staticClass:"grid-x grid-margin-x align-center"},[s("div",{staticClass:"cell medium-3 text-center footer-col"},[s("a",{staticClass:"footer-icon",attrs:{href:t.cv,target:"_blank"}},[s("img",{attrs:{src:"/static/footer_images/avatar/Avatar.svg",alt:"cv"}}),t._v(" "),s("p",[t._v("CV")])])]),t._v(" "),t._m(1),t._v(" "),t._m(2),t._v(" "),t._m(3)])]),t._v(" "),s("div",{staticClass:"footer-bg"})])},staticRenderFns:[function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"text-center heading"},[e("h4",[this._v("Contact me")])])},function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"cell medium-3  text-center footer-col"},[e("a",{staticClass:"footer-icon",attrs:{href:"mailto:nerija.balan@gmail.com"}},[e("img",{attrs:{src:"/static/footer_images/mail/e-mail.svg",alt:"mail"}}),this._v(" "),e("p",[this._v("nerija.balan@gmail.com")])])])},function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"cell medium-3  text-center footer-col"},[e("a",{staticClass:"footer-icon",attrs:{href:"#"}},[e("img",{attrs:{src:"/static/footer_images/phone/phone.svg",alt:"phone"}}),this._v(" "),e("p",[this._v("+45 42 67 10 72")])])])},function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"cell medium-3  text-center footer-col"},[e("a",{staticClass:"footer-icon",attrs:{href:"https://www.linkedin.com/in/nerija-butkevi%C4%8Di%C5%ABt%C4%97-balan-41176445/",target:"_blank"}},[e("img",{attrs:{src:"/static/footer_images/linkedin/LinkedIn.svg",alt:"linkedin"}}),this._v(" "),e("p",[this._v("LinkedIn")])])])}]},x=s("VU/8")(C,j,!1,null,null,null).exports,w={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",[null!=t.project?s("div",[null!=t.project.Detail?s("div",{staticClass:"hero-section-responsive",style:{"background-image":"url("+t.project.Detail.Hero+")"}},[s("div",{staticClass:"hero-section-text"},[s("h1",[t._v(t._s(t.project.General.Title)+" ")]),t._v(" "),s("div",{staticClass:"text-center"},[s("h5",[t._v(" Client: "+t._s(t.project.Detail.ClientName)+"  "),s("br"),t._v(" Year: "+t._s(t.project.Detail.Year)+" "),s("br"),t._v(" Role: "+t._s(t.project.Detail.Role))])]),t._v(" "),s("div",{staticClass:"hero-description",domProps:{innerHTML:t._s(t.project.General.Description)}})])]):t._e(),t._v(" "),t._l(t.project.ContentRows,function(e){return null!=t.project.ContentRows&&null!=e?s("div",{key:e.BigHeading,staticClass:"row content-row-responsive"},[s("div",{staticClass:"grid-x"},[s("div",{staticClass:"cell small-12 icon-container text-center"},[null!=e.BigHeading?s("h2",[t._v(t._s(e.BigHeading))]):t._e(),t._v(" "),null!=e.Icon?s("img",{staticClass:"icon",attrs:{src:e.Icon,alt:e.BigHeading||e.SmallHeading}}):t._e(),t._v(" "),null!=e.SmallHeading?s("h3",{staticClass:"small-heading"},[t._v(t._s(e.SmallHeading))]):t._e()]),t._v(" "),null!=e.TextColumnLeft?s("div",{staticClass:"cell small-12 text"},[s("p",[t._v("\n                        "+t._s(e.TextColumnLeft)+"\n                        ")])]):t._e(),t._v(" "),e.TextColumnRight?s("div",{staticClass:"cell small-12 text"},[s("p",[t._v("\n                        "+t._s(e.TextColumnRight)+"\n                        ")])]):t._e()]),t._v(" "),s("div",{staticClass:"grid-x"},[s("div",{staticClass:"cell medium-12"},[s("img",{staticClass:"main-image",attrs:{src:e.Image,alt:e.BigHeading||e.SmallHeading}})])])]):t._e()})],2):t._e()])},staticRenderFns:[]},k=s("VU/8")({name:"SingleProjectResponsive",props:["project"]},w,!1,null,null,null).exports,b={name:"FooterResponsive",data:function(){return{cv:"",cvText:""}},mounted:function(){var t=this;o.a.get("/umbraco/Api/ContentApi/GetResume?websiteName=Nerija").then(function(e){t.cv=e.data.Cv,t.cvText=e.data.CvText})}},P={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("footer",{staticClass:"site-footer-small"},[t._m(0),t._v(" "),s("div",{staticClass:"grid-container"},[s("div",{staticClass:"grid-x align-center"},[s("div",{staticClass:"cell medium-3 small-3 text-center footer-col"},[s("a",{staticClass:"footer-icon-small",attrs:{href:t.cv,target:"_blank"}},[s("img",{attrs:{src:"/static/footer_images/avatar/Avatar.svg",alt:"cv"}}),t._v(" "),s("p",[t._v("CV")])])]),t._v(" "),t._m(1),t._v(" "),t._m(2),t._v(" "),t._m(3)])]),t._v(" "),s("div",{staticClass:"footer-bg"})])},staticRenderFns:[function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"text-center heading"},[e("h4",[this._v("Contact me")])])},function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"cell medium-3 small-3 text-center footer-col"},[e("a",{staticClass:"footer-icon",attrs:{href:"mailto:nerija.balan@gmail.com"}},[e("img",{attrs:{src:"/static/footer_images/mail/e-mail.svg",alt:"mail"}}),this._v(" "),e("p",[this._v("nerija.balan@gmail.com")])])])},function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"cell medium-3 small-3 text-center footer-col"},[e("a",{staticClass:"footer-icon",attrs:{href:"#"}},[e("img",{attrs:{src:"/static/footer_images/phone/phone.svg",alt:"phone"}}),this._v(" "),e("p",[e("a",{attrs:{href:"tel:+4542671072"}},[this._v(" 42 67 10 72")])])])])},function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"cell medium-3 small-3 text-center footer-col"},[e("a",{staticClass:"footer-icon",attrs:{href:"https://www.linkedin.com/in/nerija-butkevi%C4%8Di%C5%ABt%C4%97-balan-41176445/",target:"_blank"}},[e("img",{attrs:{src:"/static/footer_images/linkedin/LinkedIn.svg",alt:"linkedin"}}),this._v(" "),e("p",[this._v("LinkedIn")])])])}]},R=s("VU/8")(b,P,!1,null,null,null).exports,H={name:"Project",data:function(){return{project:""}},mounted:function(){var t=this,e="/umbraco/Api/ProjectsApi/GetProject/ssqq?projectId="+document.getElementById("pid").value;o.a.get(e).then(function(e){t.project=e.data})},components:{NavigationNerija:v,SingleProjectPage:p,RelatedProjects:f,Footer:x,SingleProjectResponsive:k,FooterResponsive:R}},L={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{attrs:{id:"project"}},[s("NavigationNerija"),t._v(" "),s("div",{staticClass:"large-visible medium-hidden"},[s("SingleProjectPage",{attrs:{project:t.project}}),t._v(" "),s("RelatedProjects",{attrs:{relatedProjects:t.project.SimilarProjects}}),t._v(" "),s("Footer")],1),t._v(" "),s("div",{staticClass:"large-hidden medium-visible"},[s("SingleProjectResponsive",{attrs:{project:t.project}}),t._v(" "),s("RelatedProjects",{attrs:{relatedProjects:t.project.SimilarProjects}}),t._v(" "),s("FooterResponsive")],1)],1)},staticRenderFns:[]};var I=s("VU/8")(H,L,!1,function(t){s("jO42")},null,null).exports,T=(s("9qgI"),{render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"rocket-animation-container",attrs:{id:"rockets"},on:{mouseenter:function(e){t.isHoverIn=!0}}},[s("img",{staticClass:"rockets",attrs:{src:"/static/Rockets/Rockets.svg"}}),t._v(" "),s("transition-group",{staticClass:"smoke-container",attrs:{name:"bounce-in",tag:"div"}},[t.isHoverIn?s("img",{key:"smoke-1",attrs:{src:"/static/Rockets/rocketSmoke.svg",alt:"small-smoke-1"}}):t._e()]),t._v(" "),s("div",{staticClass:"shadow-container animation-container"},[s("transition",{key:"back",attrs:{name:"slide-in",tag:"div"}},[t.isHoverIn?s("div",{staticClass:"back-shadows"}):t._e()]),t._v(" "),s("transition",{key:"front",attrs:{name:"slide-in",tag:"div"}},[t.isHoverIn?s("div",{staticClass:"front-shadows"}):t._e()])],1)],1)},staticRenderFns:[]}),y={name:"Parallax",props:["projectMeta"],components:{Rockets:s("VU/8")({name:"Rockets",data:function(){return{hasScrolled:"",isHoverIn:""}}},T,!1,null,null,null).exports}},E={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"mb_parallax_container"},[s("div",{staticClass:"mb_parallax_overlay"},[null!=t.projectMeta?s("div",{staticClass:"grid-x headline-container hide-for-small-only"},[s("div",{staticClass:"medium-12 "},[s("h1",{staticClass:"text-center"},[t._v(" "+t._s(t.projectMeta.Heading1))])]),t._v(" "),s("div",{staticClass:"medium-12 detail-container"},[s("p",{staticClass:"text-center"},[t._v(t._s(t.projectMeta.Heading2))])])]):t._e(),t._v(" "),null!=t.projectMeta?s("div",{staticClass:"headline-container-responsive show-for-small-only responsive"},[s("h3",{staticClass:"text-center"},[t._v(" "+t._s(t.projectMeta.Heading1)+" ")]),t._v(" "),s("div",{staticClass:"text-center"},[t._v(t._s(t.projectMeta.Heading2))])]):t._e(),t._v(" "),s("Rockets")],1)])},staticRenderFns:[]},S=s("VU/8")(y,E,!1,null,null,null).exports,F={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"projectlist-container"},[s("div",{staticClass:"hero-section-meta medium-visible small-hidden",style:{"background-image":"url( /static/parallax-big-responsive.png)"}}),t._v(" "),s("div",{staticClass:"hero-section-text-meta medium-visible small-hidden"},[s("h4",{staticClass:"medium-visible"},[t._v("\n              "+t._s(t.meta.Heading1)+"\n          ")]),t._v(" "),s("p",{staticClass:"hero-description-meta"},[t._v(t._s(t.meta.Heading2))]),t._v(" "),t._m(0)]),t._v(" "),s("img",{staticClass:"small-visible medium-hidden parallax-small",attrs:{src:"/static/parallax-big-responsive.png",alt:"parallax"}}),t._v(" "),s("div",{staticClass:"small-visible medium-hidden text-overlay-small"},[s("h4",[t._v(t._s(t.meta.Heading1))]),t._v(" "),s("p",[t._v(t._s(t.meta.Heading2))]),t._v(" "),t._m(1)])])},staticRenderFns:[function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"rocket-animation-container"},[e("img",{staticClass:"rockets",attrs:{src:"/static/Rockets/Rockets.svg"}}),this._v(" "),e("div",{staticClass:"smoke-container"},[e("img",{attrs:{src:"/static/Rockets/rocketSmoke.svg",alt:"small-smoke-1"}}),this._v(" "),e("img",{staticClass:"back-shadows",attrs:{src:"/static/Rockets/BackShadows.svg",alt:"back shadows"}}),this._v(" "),e("img",{staticClass:"front-shadows",attrs:{src:"/static/Rockets/FrontShadows.svg",alt:"front shadows"}})])])},function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"rocket-animation-container"},[e("img",{staticClass:"rockets",attrs:{src:"/static/Rockets/Rockets.svg"}}),this._v(" "),e("div",{staticClass:"smoke-container"},[e("img",{staticClass:"small-smoke",attrs:{src:"/static/Rockets/rocketSmoke.svg",alt:"small-smoke-1"}}),this._v(" "),e("img",{staticClass:"back-shadows",attrs:{src:"/static/Rockets/BackShadows.svg",alt:"back shadows"}}),this._v(" "),e("img",{staticClass:"front-shadows",attrs:{src:"/static/Rockets/FrontShadows.svg",alt:"front shadows"}})])])}]},$=s("VU/8")({name:"ProjectListMeta",props:["meta"]},F,!1,null,null,null).exports,D={name:"ProjectDetail",props:["project"],data:function(){return{isHoverIn:""}},methods:{featuredClick:function(t){window.location.href=t}}},N={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return t.project?s("div",{key:t.project.Udi,staticClass:"cell medium-4 featured-project",on:{mouseenter:function(e){t.isHoverIn=!0},mouseleave:function(e){t.isHoverIn=!1},click:function(e){t.featuredClick(t.project.Url)}}},[s("transition-group",{staticClass:"overlay-container",attrs:{name:"slide-fade",tag:"div"}},[null!=t.isHoverIn?s("img",{key:"startImg",staticClass:"overlay",attrs:{src:null!=t.isHoverIn&&""!=t.isHoverIn&&t.isHoverIn?t.project.ListDetail.WebListPlaceholder:t.project.ListDetail.WebListImage,alt:t.project.Title,width:"100%"}}):t._e(),t._v(" "),null!=t.isHoverIn&&""!=t.isHoverIn&&t.isHoverIn?t._e():s("h3",{key:"startTitle",staticClass:"text-center placeholder-title inactive"},[t._v(" "+t._s(t.project.General.Title))]),t._v(" "),null!=t.isHoverIn&&t.isHoverIn?s("h3",{key:"activeTitle",staticClass:"activeTitle"},[t._v(t._s(t.project.General.Title))]):t._e(),t._v(" "),null!=t.isHoverIn&&t.isHoverIn?s("h4",{key:"activeDescription",staticClass:"activeDescription"},[t._v(t._s(t.project.General.Teaser))]):t._e(),t._v(" "),null!=t.isHoverIn&&t.isHoverIn?s("h5",{key:"readMore",staticClass:"readMore"},[t._v(" Read more")]):t._e()])],1):t._e()},staticRenderFns:[]},U={name:"ProjectList",props:["projects","topProjects","restProjects"],data:function(){return{cv:"",cvText:"",expandedView:!1,count:0}},mounted:function(){var t=this;o.a.get("/umbraco/Api/ContentApi/GetResume?websiteName=Nerija").then(function(e){t.cv=e.data.Cv,t.cvText=e.data.CvText})},methods:{showMore:function(){this.expandedView=!0},showLess:function(){this.expandedView=!1},track:function(){var t=window.location.origin+window.location.pathname;Object(a.page)(t)}},components:{ProjectDetail:s("VU/8")(D,N,!1,null,null,null).exports}},A={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"projectlist-container"},[t._m(0),t._v(" "),s("div",{staticClass:"grid-x"},[null!=t.projects?[t._l(t.topProjects,function(t){return[s("ProjectDetail",{key:t.Udi,attrs:{project:t}})]}),t._v(" "),!t.expandedView&&null!=t.restProjects&&t.restProjects.length>0?s("div",{staticClass:"cell large-12 text-center show-more-container"},[s("button",{staticClass:"hollow button primary",on:{click:function(e){t.showMore()}}},[s("font-awesome-icon",{attrs:{icon:"chevron-circle-down"}}),t._v(" Show more ")],1)]):t._e(),t._v(" "),t._l(t.restProjects,function(e,i){return t.expandedView&&null!=t.restProjects?[s("ProjectDetail",{key:e.Udi,attrs:{project:e}})]:t._e()}),t._v(" "),t.expandedView?s("div",{staticClass:"cell large-12 text-center show-more-container"},[s("button",{staticClass:"hollow button primary",on:{click:function(e){t.showLess()}}},[s("font-awesome-icon",{attrs:{icon:"chevron-circle-up"}}),t._v(" Show less ")],1)]):t._e()]:t._e()],2)])},staticRenderFns:[function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"text-center heading"},[e("h4",[this._v("Projects")])])}]},V={name:"ProjectListResponsive",props:["projects"],data:function(){return{count:0}},methods:{track:function(){var t=window.location.origin+window.location.pathname;Object(a.page)(t)},viewDetail:function(t){window.location.href=t}}},M={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"parent-container"},[t._m(0),t._v(" "),null!=t.projects?s("div",{staticClass:"projects-container text-center grid-x"},t._l(t.projects,function(e){return s("div",{key:e.Udi,staticClass:"project cell medium-6 small-12",on:{click:function(s){t.viewDetail(e.Url)}}},[s("div",[s("img",{attrs:{src:e.ListDetail.WebListImage,alt:e.General.Title}}),t._v(" "),s("div",[s("p",{staticClass:"text-center"},[t._v(t._s(e.General.Title)+" ")])])])])})):t._e()])},staticRenderFns:[function(){var t=this.$createElement,e=this._self._c||t;return e("div",{staticClass:"project-list-header"},[e("h4",{staticClass:"text-center"},[this._v("Projects")])])}]},B={name:"ProjectListApp",data:function(){return{meta:"",projList:"",topList:"",bottomList:""}},mounted:function(){var t=this;o.a.get("/umbraco/Api/ProjectsApi/GetProjects?website=Nerija").then(function(e){var s=e.data.Projects;t.projList=s,t.count=s.length,s.length>9?(t.topList=s.slice(0,9),t.bottomList=s.slice(9,s.length),console.log(t.bottomList)):t.topList=s,t.meta=e.data})},components:{NavigationNerija:v,Parallax:S,ProjectList:s("VU/8")(U,A,!1,null,null,null).exports,ProjectListMeta:$,ProjectListResponsive:s("VU/8")(V,M,!1,null,null,null).exports,Footer:x,FooterResponsive:R}},G={render:function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",[s("div",{staticClass:"large-visible medium-hidden",attrs:{id:"projectlist"}},[s("NavigationNerija"),t._v(" "),s("Parallax",{attrs:{projectMeta:t.meta}}),t._v(" "),s("ProjectList",{attrs:{projects:t.projList,topProjects:t.topList,restProjects:t.bottomList}}),t._v(" "),s("Footer")],1),t._v(" "),s("div",{staticClass:"large-hidden medium-visible"},[s("NavigationNerija"),t._v(" "),s("ProjectListMeta",{attrs:{meta:t.meta}}),t._v(" "),s("ProjectListResponsive",{attrs:{projects:t.projList}}),t._v(" "),s("FooterResponsive")],1)])},staticRenderFns:[]};var W=s("VU/8")(B,G,!1,function(t){s("TuZm")},null,null).exports,Y=s("C/JF"),O=s("fhbW"),q=s("U0v6");i.a.use(n.a,{id:"UA-143407872-1"}),Y.library.add([O.e,O.c,O.d,O.a,O.b]),i.a.component("font-awesome-icon",q.FontAwesomeIcon),i.a.component("Project",I),i.a.component("ProjectList",W),i.a.config.productionTip=!1,document.getElementById("project")&&new i.a({el:"#project",template:"<Project/>",components:{Project:I}}),document.getElementById("projects")&&new i.a({el:"#projects",template:"<ProjectListApp/>",components:{ProjectListApp:W}})},TuZm:function(t,e){},jO42:function(t,e){}},["NHnr"]);