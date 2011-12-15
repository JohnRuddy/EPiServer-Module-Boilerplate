using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.SpecializedProperties;
using Lucene.Net.Search;
using PageTypeBuilder;
using PageTypeBuilder.UI;

namespace EPiServer_Module_Boilerplate.Modules.SampleModule.PageTypes
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    [PageType(Filename = "~/Modules/SampleModule/Templates/Pages/DemoPage.aspx",
        Name = "[Sample Module] DemoPage Page")]
    public class DemoPageType : TypedPageData
    {
        /// <summary>
        /// Gets or sets the content of the page.
        /// </summary>
        /// <value>The content of the page.</value>
        /// <remarks></remarks>
        [PageTypeProperty(Type = typeof (PropertyXhtmlString),
            EditCaption = "Demo Page",
            HelpText = "Edit the Demo Page",
            SortOrder = 1,
            Required = true,
            Tab = typeof (DemoPageTab),
            UniqueValuePerLanguage = false)]
        public virtual string PageContent { get; set; }
    }
}