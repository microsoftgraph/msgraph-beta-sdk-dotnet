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
    /// The type FinancialsCompaniesCollectionRequestBuilder.
    /// </summary>
    public partial class FinancialsCompaniesCollectionRequestBuilder : BaseRequestBuilder, IFinancialsCompaniesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new FinancialsCompaniesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public FinancialsCompaniesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IFinancialsCompaniesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IFinancialsCompaniesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new FinancialsCompaniesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICompanyRequestBuilder"/> for the specified FinancialsCompany.
        /// </summary>
        /// <param name="id">The ID for the FinancialsCompany.</param>
        /// <returns>The <see cref="ICompanyRequestBuilder"/>.</returns>
        public ICompanyRequestBuilder this[string id]
        {
            get
            {
                return new CompanyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}