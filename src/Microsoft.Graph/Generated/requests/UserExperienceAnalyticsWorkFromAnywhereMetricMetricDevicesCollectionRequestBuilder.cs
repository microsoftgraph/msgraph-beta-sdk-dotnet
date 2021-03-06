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
    /// The type UserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequestBuilder.
    /// </summary>
    public partial class UserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequestBuilder : BaseRequestBuilder, IUserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserExperienceAnalyticsWorkFromAnywhereMetricMetricDevicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsWorkFromAnywhereDeviceRequestBuilder"/> for the specified UserExperienceAnalyticsWorkFromAnywhereMetricUserExperienceAnalyticsWorkFromAnywhereDevice.
        /// </summary>
        /// <param name="id">The ID for the UserExperienceAnalyticsWorkFromAnywhereMetricUserExperienceAnalyticsWorkFromAnywhereDevice.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsWorkFromAnywhereDeviceRequestBuilder"/>.</returns>
        public IUserExperienceAnalyticsWorkFromAnywhereDeviceRequestBuilder this[string id]
        {
            get
            {
                return new UserExperienceAnalyticsWorkFromAnywhereDeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
