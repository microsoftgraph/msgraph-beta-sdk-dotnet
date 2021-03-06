// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type OutlookUserRequestBuilder.
    /// </summary>
    public partial class OutlookUserRequestBuilder : EntityRequestBuilder, IOutlookUserRequestBuilder
    {

        /// <summary>
        /// Constructs a new OutlookUserRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OutlookUserRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOutlookUserRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOutlookUserRequest Request(IEnumerable<Option> options)
        {
            return new OutlookUserRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for MasterCategories.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserMasterCategoriesCollectionRequestBuilder"/>.</returns>
        public IOutlookUserMasterCategoriesCollectionRequestBuilder MasterCategories
        {
            get
            {
                return new OutlookUserMasterCategoriesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("masterCategories"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TaskFolders.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserTaskFoldersCollectionRequestBuilder"/>.</returns>
        public IOutlookUserTaskFoldersCollectionRequestBuilder TaskFolders
        {
            get
            {
                return new OutlookUserTaskFoldersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("taskFolders"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TaskGroups.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserTaskGroupsCollectionRequestBuilder"/>.</returns>
        public IOutlookUserTaskGroupsCollectionRequestBuilder TaskGroups
        {
            get
            {
                return new OutlookUserTaskGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("taskGroups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserTasksCollectionRequestBuilder"/>.</returns>
        public IOutlookUserTasksCollectionRequestBuilder Tasks
        {
            get
            {
                return new OutlookUserTasksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for OutlookUserSupportedLanguages.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserSupportedLanguagesRequestBuilder"/>.</returns>
        public IOutlookUserSupportedLanguagesRequestBuilder SupportedLanguages()
        {
            return new OutlookUserSupportedLanguagesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.supportedLanguages"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for OutlookUserSupportedTimeZones.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserSupportedTimeZonesRequestBuilder"/>.</returns>
        public IOutlookUserSupportedTimeZonesRequestBuilder SupportedTimeZones()
        {
            return new OutlookUserSupportedTimeZonesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.supportedTimeZones"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for OutlookUserSupportedTimeZones.
        /// </summary>
        /// <returns>The <see cref="IOutlookUserSupportedTimeZonesRequestBuilder"/>.</returns>
        public IOutlookUserSupportedTimeZonesRequestBuilder SupportedTimeZones(
            TimeZoneStandard TimeZoneStandard)
        {
            return new OutlookUserSupportedTimeZonesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.supportedTimeZones"),
                this.Client,
                TimeZoneStandard);
        }
    
    }
}
