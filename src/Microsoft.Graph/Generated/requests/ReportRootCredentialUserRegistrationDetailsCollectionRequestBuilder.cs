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
    /// The type ReportRootCredentialUserRegistrationDetailsCollectionRequestBuilder.
    /// </summary>
    public partial class ReportRootCredentialUserRegistrationDetailsCollectionRequestBuilder : BaseRequestBuilder, IReportRootCredentialUserRegistrationDetailsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ReportRootCredentialUserRegistrationDetailsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ReportRootCredentialUserRegistrationDetailsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IReportRootCredentialUserRegistrationDetailsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IReportRootCredentialUserRegistrationDetailsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ReportRootCredentialUserRegistrationDetailsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICredentialUserRegistrationDetailsRequestBuilder"/> for the specified ReportRootCredentialUserRegistrationDetails.
        /// </summary>
        /// <param name="id">The ID for the ReportRootCredentialUserRegistrationDetails.</param>
        /// <returns>The <see cref="ICredentialUserRegistrationDetailsRequestBuilder"/>.</returns>
        public ICredentialUserRegistrationDetailsRequestBuilder this[string id]
        {
            get
            {
                return new CredentialUserRegistrationDetailsRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}