// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type CustodianSiteSourcesCollectionRequestBuilder.
    /// </summary>
    public partial class CustodianSiteSourcesCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ICustodianSiteSourcesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CustodianSiteSourcesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public CustodianSiteSourcesCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICustodianSiteSourcesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICustodianSiteSourcesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new CustodianSiteSourcesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISiteSourceRequestBuilder"/> for the specified CustodianSiteSource.
        /// </summary>
        /// <param name="id">The ID for the CustodianSiteSource.</param>
        /// <returns>The <see cref="ISiteSourceRequestBuilder"/>.</returns>
        public ISiteSourceRequestBuilder this[string id]
        {
            get
            {
                return new SiteSourceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
