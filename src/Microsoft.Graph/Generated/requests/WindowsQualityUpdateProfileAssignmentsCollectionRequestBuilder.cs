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
    /// The type WindowsQualityUpdateProfileAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class WindowsQualityUpdateProfileAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IWindowsQualityUpdateProfileAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsQualityUpdateProfileAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsQualityUpdateProfileAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsQualityUpdateProfileAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsQualityUpdateProfileAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WindowsQualityUpdateProfileAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsQualityUpdateProfileAssignmentRequestBuilder"/> for the specified WindowsQualityUpdateProfileWindowsQualityUpdateProfileAssignment.
        /// </summary>
        /// <param name="id">The ID for the WindowsQualityUpdateProfileWindowsQualityUpdateProfileAssignment.</param>
        /// <returns>The <see cref="IWindowsQualityUpdateProfileAssignmentRequestBuilder"/>.</returns>
        public IWindowsQualityUpdateProfileAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new WindowsQualityUpdateProfileAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
