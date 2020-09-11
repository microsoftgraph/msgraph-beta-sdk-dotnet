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
    /// The type GraphServiceTasksCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceTasksCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceTasksCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceTasksCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceTasksCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceTasksCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceTasksCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceTasksCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITodoTaskRequestBuilder"/> for the specified GraphServiceTodoTask.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceTodoTask.</param>
        /// <returns>The <see cref="ITodoTaskRequestBuilder"/>.</returns>
        public ITodoTaskRequestBuilder this[string id]
        {
            get
            {
                return new TodoTaskRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TodoTaskDelta.
        /// </summary>
        /// <returns>The <see cref="ITodoTaskDeltaRequestBuilder"/>.</returns>
        public ITodoTaskDeltaRequestBuilder Delta()
        {
            return new TodoTaskDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}