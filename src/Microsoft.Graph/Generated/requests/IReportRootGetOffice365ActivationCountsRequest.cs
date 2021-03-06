// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IReportRootGetOffice365ActivationCountsRequest.
    /// </summary>
    public partial interface IReportRootGetOffice365ActivationCountsRequest : IBaseRequest
    {

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<IReportRootGetOffice365ActivationCountsCollectionPage> GetAsync();

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ActivationCountsCollectionPage> GetAsync(
            CancellationToken cancellationToken);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="office365activationcounts">The Office365ActivationCounts object set with the properties to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ActivationCountsCollectionPage> PatchAsync(Office365ActivationCounts office365activationcounts);

        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="office365activationcounts">The Office365ActivationCounts object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ActivationCountsCollectionPage> PatchAsync(Office365ActivationCounts office365activationcounts,
            CancellationToken cancellationToken);


        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="office365activationcounts">The Office365ActivationCounts object to update.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ActivationCountsCollectionPage> PutAsync(Office365ActivationCounts office365activationcounts);

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="office365activationcounts">The Office365ActivationCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ActivationCountsCollectionPage> PutAsync(Office365ActivationCounts office365activationcounts,
            CancellationToken cancellationToken);


        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ActivationCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ActivationCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ActivationCountsRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ActivationCountsRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ActivationCountsRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ActivationCountsRequest OrderBy(string value);
    }
}
