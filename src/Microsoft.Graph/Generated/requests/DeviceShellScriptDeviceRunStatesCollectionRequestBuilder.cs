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
    /// The type DeviceShellScriptDeviceRunStatesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceShellScriptDeviceRunStatesCollectionRequestBuilder : BaseRequestBuilder, IDeviceShellScriptDeviceRunStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceShellScriptDeviceRunStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceShellScriptDeviceRunStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceShellScriptDeviceRunStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceShellScriptDeviceRunStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceShellScriptDeviceRunStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceManagementScriptDeviceStateRequestBuilder"/> for the specified DeviceShellScriptDeviceManagementScriptDeviceState.
        /// </summary>
        /// <param name="id">The ID for the DeviceShellScriptDeviceManagementScriptDeviceState.</param>
        /// <returns>The <see cref="IDeviceManagementScriptDeviceStateRequestBuilder"/>.</returns>
        public IDeviceManagementScriptDeviceStateRequestBuilder this[string id]
        {
            get
            {
                return new DeviceManagementScriptDeviceStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
