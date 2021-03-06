// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IVirtualEndpointAuditEventsCollectionRequestBuilder.
    /// </summary>
    public partial interface IVirtualEndpointAuditEventsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IVirtualEndpointAuditEventsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IVirtualEndpointAuditEventsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICloudPcAuditEventRequestBuilder"/> for the specified CloudPcAuditEvent.
        /// </summary>
        /// <param name="id">The ID for the CloudPcAuditEvent.</param>
        /// <returns>The <see cref="ICloudPcAuditEventRequestBuilder"/>.</returns>
        ICloudPcAuditEventRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for CloudPcAuditEventGetAuditActivityTypes.
        /// </summary>
        /// <returns>The <see cref="ICloudPcAuditEventGetAuditActivityTypesRequestBuilder"/>.</returns>
        ICloudPcAuditEventGetAuditActivityTypesRequestBuilder GetAuditActivityTypes();
    }
}
