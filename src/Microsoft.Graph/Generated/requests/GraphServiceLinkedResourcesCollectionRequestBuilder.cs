// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceLinkedResourcesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceLinkedResourcesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceLinkedResourcesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceLinkedResourcesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceLinkedResourcesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceLinkedResourcesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceLinkedResourcesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceLinkedResourcesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ILinkedResourceRequestBuilder"/> for the specified GraphServiceLinkedResource.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceLinkedResource.</param>
        /// <returns>The <see cref="ILinkedResourceRequestBuilder"/>.</returns>
        public ILinkedResourceRequestBuilder this[string id]
        {
            get
            {
                return new LinkedResourceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}