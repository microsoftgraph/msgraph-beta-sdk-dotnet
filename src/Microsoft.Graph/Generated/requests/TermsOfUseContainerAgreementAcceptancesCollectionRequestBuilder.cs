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
    /// The type TermsOfUseContainerAgreementAcceptancesCollectionRequestBuilder.
    /// </summary>
    public partial class TermsOfUseContainerAgreementAcceptancesCollectionRequestBuilder : BaseRequestBuilder, ITermsOfUseContainerAgreementAcceptancesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TermsOfUseContainerAgreementAcceptancesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TermsOfUseContainerAgreementAcceptancesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITermsOfUseContainerAgreementAcceptancesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITermsOfUseContainerAgreementAcceptancesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TermsOfUseContainerAgreementAcceptancesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAgreementAcceptanceRequestBuilder"/> for the specified TermsOfUseContainerAgreementAcceptance.
        /// </summary>
        /// <param name="id">The ID for the TermsOfUseContainerAgreementAcceptance.</param>
        /// <returns>The <see cref="IAgreementAcceptanceRequestBuilder"/>.</returns>
        public IAgreementAcceptanceRequestBuilder this[string id]
        {
            get
            {
                return new AgreementAcceptanceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
