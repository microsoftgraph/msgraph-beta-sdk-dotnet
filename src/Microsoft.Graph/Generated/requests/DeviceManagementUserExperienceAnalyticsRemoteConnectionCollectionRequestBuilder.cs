// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementUserExperienceAnalyticsRemoteConnectionCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsRemoteConnectionRequestBuilder"/> for the specified DeviceManagementUserExperienceAnalyticsRemoteConnection.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementUserExperienceAnalyticsRemoteConnection.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsRemoteConnectionRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsRemoteConnectionRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsRemoteConnectionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserExperienceAnalyticsRemoteConnectionSummarizeDeviceRemoteConnection.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsRemoteConnectionSummarizeDeviceRemoteConnectionRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsRemoteConnectionSummarizeDeviceRemoteConnectionRequestBuilder SummarizeDeviceRemoteConnection(
            UserExperienceAnalyticsSummarizedBy summarizeBy)
        {
            return new UserExperienceAnalyticsRemoteConnectionSummarizeDeviceRemoteConnectionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.summarizeDeviceRemoteConnection"),
                this.Client,
                summarizeBy);
        }
    }
}
