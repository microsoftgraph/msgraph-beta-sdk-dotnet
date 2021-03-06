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
    /// The type PlannerRostersCollectionRequestBuilder.
    /// </summary>
    public partial class PlannerRostersCollectionRequestBuilder : BaseRequestBuilder, IPlannerRostersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PlannerRostersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerRostersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPlannerRostersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPlannerRostersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PlannerRostersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPlannerRosterRequestBuilder"/> for the specified PlannerPlannerRoster.
        /// </summary>
        /// <param name="id">The ID for the PlannerPlannerRoster.</param>
        /// <returns>The <see cref="IPlannerRosterRequestBuilder"/>.</returns>
        public IPlannerRosterRequestBuilder this[string id]
        {
            get
            {
                return new PlannerRosterRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
