using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EPiServer;
using EPiServer_Module_Boilerplate.Modules.SampleModule.PageTypes;
using PageTypeBuilder.UI;

namespace EPiServer_Module_Boilerplate.Modules.SampleModule.Templates.Pages
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public partial class DemoPage : TemplatePage<DemoPageType> 
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <remarks></remarks>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}