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
    /// The type EdiscoveryCaseCustodiansCollectionRequestBuilder.
    /// </summary>
    public partial class EdiscoveryCaseCustodiansCollectionRequestBuilder : BaseRequestBuilder, IEdiscoveryCaseCustodiansCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EdiscoveryCaseCustodiansCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EdiscoveryCaseCustodiansCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryCaseCustodiansCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryCaseCustodiansCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EdiscoveryCaseCustodiansCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICustodianRequestBuilder"/> for the specified EdiscoveryCaseCustodian.
        /// </summary>
        /// <param name="id">The ID for the EdiscoveryCaseCustodian.</param>
        /// <returns>The <see cref="ICustodianRequestBuilder"/>.</returns>
        public ICustodianRequestBuilder this[string id]
        {
            get
            {
                return new CustodianRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}