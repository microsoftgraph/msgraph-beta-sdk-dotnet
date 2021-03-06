// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type QualityUpdateCatalogEntryRequestBuilder.
    /// </summary>
    public partial class QualityUpdateCatalogEntryRequestBuilder : SoftwareUpdateCatalogEntryRequestBuilder, IQualityUpdateCatalogEntryRequestBuilder
    {

        /// <summary>
        /// Constructs a new QualityUpdateCatalogEntryRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public QualityUpdateCatalogEntryRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IQualityUpdateCatalogEntryRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IQualityUpdateCatalogEntryRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new QualityUpdateCatalogEntryRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
