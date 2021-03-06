// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantConditionalAccessPolicyCoveragesCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedTenantConditionalAccessPolicyCoveragesCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantConditionalAccessPolicyCoveragesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedTenantConditionalAccessPolicyCoveragesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantConditionalAccessPolicyCoveragesCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantConditionalAccessPolicyCoveragesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantConditionalAccessPolicyCoveragesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantConditionalAccessPolicyCoveragesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConditionalAccessPolicyCoverageRequestBuilder"/> for the specified ManagedTenantConditionalAccessPolicyCoverage.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantConditionalAccessPolicyCoverage.</param>
        /// <returns>The <see cref="IConditionalAccessPolicyCoverageRequestBuilder"/>.</returns>
        public IConditionalAccessPolicyCoverageRequestBuilder this[string id]
        {
            get
            {
                return new ConditionalAccessPolicyCoverageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
