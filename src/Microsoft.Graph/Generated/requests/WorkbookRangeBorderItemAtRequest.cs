// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkbookRangeBorderItemAtRequest.
    /// </summary>
    public partial class WorkbookRangeBorderItemAtRequest : BaseRequest, IWorkbookRangeBorderItemAtRequest
    {
        /// <summary>
        /// Constructs a new WorkbookRangeBorderItemAtRequest.
        /// </summary>
        public WorkbookRangeBorderItemAtRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        public System.Threading.Tasks.Task<WorkbookRangeBorder> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeBorder> GetAsync(
            CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return this.SendAsync<WorkbookRangeBorder>(null, cancellationToken);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbookrangeborder">The WorkbookRangeBorder object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeBorder> PatchAsync(WorkbookRangeBorder workbookrangeborder)
        {
            return this.PatchAsync(workbookrangeborder, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="workbookrangeborder">The WorkbookRangeBorder object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeBorder> PatchAsync(WorkbookRangeBorder workbookrangeborder,
            CancellationToken cancellationToken)
        {
            this.Method = "PATCH";
            return this.SendAsync<WorkbookRangeBorder>(workbookrangeborder, cancellationToken);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbookrangeborder">The WorkbookRangeBorder object to update.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeBorder> PutAsync(WorkbookRangeBorder workbookrangeborder)
        {
            return this.PutAsync(workbookrangeborder, CancellationToken.None);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="workbookrangeborder">The WorkbookRangeBorder object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookRangeBorder> PutAsync(WorkbookRangeBorder workbookrangeborder,
            CancellationToken cancellationToken)
        {
            this.Method = "PUT";
            return this.SendAsync<WorkbookRangeBorder>(workbookrangeborder, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeBorderItemAtRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookRangeBorderItemAtRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
