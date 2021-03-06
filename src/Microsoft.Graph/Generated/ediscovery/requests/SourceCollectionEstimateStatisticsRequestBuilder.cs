// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SourceCollectionEstimateStatisticsRequestBuilder.
    /// </summary>
    public partial class SourceCollectionEstimateStatisticsRequestBuilder : Microsoft.Graph.BaseActionMethodRequestBuilder<ISourceCollectionEstimateStatisticsRequest>, ISourceCollectionEstimateStatisticsRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="SourceCollectionEstimateStatisticsRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public SourceCollectionEstimateStatisticsRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ISourceCollectionEstimateStatisticsRequest CreateRequest(string functionUrl, IEnumerable<Microsoft.Graph.Option> options)
        {
            var request = new SourceCollectionEstimateStatisticsRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
