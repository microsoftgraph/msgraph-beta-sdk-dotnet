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
    /// The type DeviceLogCollectionResponseRequestBuilder.
    /// </summary>
    public partial class DeviceLogCollectionResponseRequestBuilder : EntityRequestBuilder, IDeviceLogCollectionResponseRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceLogCollectionResponseRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceLogCollectionResponseRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceLogCollectionResponseRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceLogCollectionResponseRequest Request(IEnumerable<Option> options)
        {
            return new DeviceLogCollectionResponseRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DeviceLogCollectionResponseCreateDownloadUrl.
        /// </summary>
        /// <returns>The <see cref="IDeviceLogCollectionResponseCreateDownloadUrlRequestBuilder"/>.</returns>
        public IDeviceLogCollectionResponseCreateDownloadUrlRequestBuilder CreateDownloadUrl()
        {
            return new DeviceLogCollectionResponseCreateDownloadUrlRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createDownloadUrl"),
                this.Client);
        }
    
    }
}
