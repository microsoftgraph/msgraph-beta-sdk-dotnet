// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICloudPCRequest.
    /// </summary>
    public partial interface ICloudPCRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPC using POST.
        /// </summary>
        /// <param name="cloudPCToCreate">The CloudPC to create.</param>
        /// <returns>The created CloudPC.</returns>
        System.Threading.Tasks.Task<CloudPC> CreateAsync(CloudPC cloudPCToCreate);        /// <summary>
        /// Creates the specified CloudPC using POST.
        /// </summary>
        /// <param name="cloudPCToCreate">The CloudPC to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPC.</returns>
        System.Threading.Tasks.Task<CloudPC> CreateAsync(CloudPC cloudPCToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CloudPC.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CloudPC.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CloudPC.
        /// </summary>
        /// <returns>The CloudPC.</returns>
        System.Threading.Tasks.Task<CloudPC> GetAsync();

        /// <summary>
        /// Gets the specified CloudPC.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPC.</returns>
        System.Threading.Tasks.Task<CloudPC> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CloudPC using PATCH.
        /// </summary>
        /// <param name="cloudPCToUpdate">The CloudPC to update.</param>
        /// <returns>The updated CloudPC.</returns>
        System.Threading.Tasks.Task<CloudPC> UpdateAsync(CloudPC cloudPCToUpdate);

        /// <summary>
        /// Updates the specified CloudPC using PATCH.
        /// </summary>
        /// <param name="cloudPCToUpdate">The CloudPC to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPC.</returns>
        System.Threading.Tasks.Task<CloudPC> UpdateAsync(CloudPC cloudPCToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPCRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPCRequest Expand(Expression<Func<CloudPC, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPCRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPCRequest Select(Expression<Func<CloudPC, object>> selectExpression);

    }
}