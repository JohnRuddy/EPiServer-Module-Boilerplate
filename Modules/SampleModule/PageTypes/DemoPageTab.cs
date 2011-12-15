using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Security;
using PageTypeBuilder;

namespace EPiServer_Module_Boilerplate.Modules.SampleModule.PageTypes
{

    /// <summary>
    /// Demo Tab
    /// </summary>
    /// <remarks></remarks>
    internal class DemoPageTab : Tab
    {
        /// <summary>
        /// Access Level tab
        /// </summary>
        private readonly AccessLevel accessLevel = AccessLevel.Read;

        /// <summary>
        /// Name of tab
        /// </summary>
        private readonly string name = "Recent Items";

        /// <summary>
        /// Sort index of tab
        /// </summary>
        private readonly int sortIndex = 1;

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <remarks></remarks>
        public override string Name
        {
            get { return this.name; }
        }

        /// <summary>
        /// Gets the required access.
        /// </summary>
        /// <value>The required access.</value>
        /// <remarks></remarks>
        public override AccessLevel RequiredAccess
        {
            get { return this.accessLevel; }
        }

        /// <summary>
        /// Gets the index of the sort.
        /// </summary>
        /// <value>The index of the sort.</value>
        /// <remarks></remarks>
        public override int SortIndex
        {
            get { return this.sortIndex; }
        }
    }

}