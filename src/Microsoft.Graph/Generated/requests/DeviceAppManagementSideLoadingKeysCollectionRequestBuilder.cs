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
    /// The type DeviceAppManagementSideLoadingKeysCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementSideLoadingKeysCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementSideLoadingKeysCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementSideLoadingKeysCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementSideLoadingKeysCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementSideLoadingKeysCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementSideLoadingKeysCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementSideLoadingKeysCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISideLoadingKeyRequestBuilder"/> for the specified DeviceAppManagementSideLoadingKey.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementSideLoadingKey.</param>
        /// <returns>The <see cref="ISideLoadingKeyRequestBuilder"/>.</returns>
        public ISideLoadingKeyRequestBuilder this[string id]
        {
            get
            {
                return new SideLoadingKeyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
