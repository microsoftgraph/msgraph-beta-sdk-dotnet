// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IExternalConnectionOperationsCollectionRequestBuilder.
    /// </summary>
    public partial interface IExternalConnectionOperationsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IExternalConnectionOperationsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IExternalConnectionOperationsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IConnectionOperationRequestBuilder"/> for the specified ConnectionOperation.
        /// </summary>
        /// <param name="id">The ID for the ConnectionOperation.</param>
        /// <returns>The <see cref="IConnectionOperationRequestBuilder"/>.</returns>
        IConnectionOperationRequestBuilder this[string id] { get; }

        
    }
}
