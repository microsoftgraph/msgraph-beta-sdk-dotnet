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
    /// The type CloudPcUserSettingAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class CloudPcUserSettingAssignmentsCollectionRequestBuilder : BaseRequestBuilder, ICloudPcUserSettingAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CloudPcUserSettingAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CloudPcUserSettingAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICloudPcUserSettingAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICloudPcUserSettingAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CloudPcUserSettingAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICloudPcUserSettingAssignmentRequestBuilder"/> for the specified CloudPcUserSettingCloudPcUserSettingAssignment.
        /// </summary>
        /// <param name="id">The ID for the CloudPcUserSettingCloudPcUserSettingAssignment.</param>
        /// <returns>The <see cref="ICloudPcUserSettingAssignmentRequestBuilder"/>.</returns>
        public ICloudPcUserSettingAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new CloudPcUserSettingAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
