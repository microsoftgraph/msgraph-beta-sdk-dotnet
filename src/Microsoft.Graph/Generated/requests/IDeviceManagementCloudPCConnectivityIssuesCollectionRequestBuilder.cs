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
    /// The interface IDeviceManagementCloudPCConnectivityIssuesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementCloudPCConnectivityIssuesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementCloudPCConnectivityIssuesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementCloudPCConnectivityIssuesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICloudPCConnectivityIssueRequestBuilder"/> for the specified CloudPCConnectivityIssue.
        /// </summary>
        /// <param name="id">The ID for the CloudPCConnectivityIssue.</param>
        /// <returns>The <see cref="ICloudPCConnectivityIssueRequestBuilder"/>.</returns>
        ICloudPCConnectivityIssueRequestBuilder this[string id] { get; }

        
    }
}
