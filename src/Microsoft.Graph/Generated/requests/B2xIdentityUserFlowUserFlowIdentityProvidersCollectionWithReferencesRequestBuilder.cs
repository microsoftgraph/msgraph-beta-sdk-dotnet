// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new B2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IIdentityProviderBaseWithReferenceRequestBuilder"/> for the specified B2xIdentityUserFlowIdentityProviderBase.
        /// </summary>
        /// <param name="id">The ID for the B2xIdentityUserFlowIdentityProviderBase.</param>
        /// <returns>The <see cref="IIdentityProviderBaseWithReferenceRequestBuilder"/>.</returns>
        public IIdentityProviderBaseWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new IdentityProviderBaseWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionReferencesRequestBuilder"/>.</returns>
        public IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionReferencesRequestBuilder References
        {
            get
            {
                return new B2xIdentityUserFlowUserFlowIdentityProvidersCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
