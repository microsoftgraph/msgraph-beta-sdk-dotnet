// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ColumnDefinitionRequestBuilder.
    /// </summary>
    public partial class ColumnDefinitionRequestBuilder : EntityRequestBuilder, IColumnDefinitionRequestBuilder
    {

        /// <summary>
        /// Constructs a new ColumnDefinitionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ColumnDefinitionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IColumnDefinitionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IColumnDefinitionRequest Request(IEnumerable<Option> options)
        {
            return new ColumnDefinitionRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SourceColumn.
        /// </summary>
        /// <returns>The <see cref="IColumnDefinitionWithReferenceRequestBuilder"/>.</returns>
        public IColumnDefinitionWithReferenceRequestBuilder SourceColumn
        {
            get
            {
                return new ColumnDefinitionWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("sourceColumn"), this.Client);
            }
        }
    
    }
}
