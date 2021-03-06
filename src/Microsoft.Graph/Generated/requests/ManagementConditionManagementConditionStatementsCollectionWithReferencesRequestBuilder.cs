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
    /// The type ManagementConditionManagementConditionStatementsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ManagementConditionManagementConditionStatementsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IManagementConditionManagementConditionStatementsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagementConditionManagementConditionStatementsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagementConditionManagementConditionStatementsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagementConditionManagementConditionStatementsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagementConditionManagementConditionStatementsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ManagementConditionManagementConditionStatementsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagementConditionStatementWithReferenceRequestBuilder"/> for the specified ManagementConditionManagementConditionStatement.
        /// </summary>
        /// <param name="id">The ID for the ManagementConditionManagementConditionStatement.</param>
        /// <returns>The <see cref="IManagementConditionStatementWithReferenceRequestBuilder"/>.</returns>
        public IManagementConditionStatementWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ManagementConditionStatementWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IManagementConditionManagementConditionStatementsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagementConditionManagementConditionStatementsCollectionReferencesRequestBuilder"/>.</returns>
        public IManagementConditionManagementConditionStatementsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ManagementConditionManagementConditionStatementsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
