// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IFeatureUpdateCatalogEntryRequestBuilder.
    /// </summary>
    public partial interface IFeatureUpdateCatalogEntryRequestBuilder : ISoftwareUpdateCatalogEntryRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IFeatureUpdateCatalogEntryRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IFeatureUpdateCatalogEntryRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
    }
}
