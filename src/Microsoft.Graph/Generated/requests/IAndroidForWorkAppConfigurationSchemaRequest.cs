// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAndroidForWorkAppConfigurationSchemaRequest.
    /// </summary>
    public partial interface IAndroidForWorkAppConfigurationSchemaRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkAppConfigurationSchema using POST.
        /// </summary>
        /// <param name="androidForWorkAppConfigurationSchemaToCreate">The AndroidForWorkAppConfigurationSchema to create.</param>
        /// <returns>The created AndroidForWorkAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidForWorkAppConfigurationSchema> CreateAsync(AndroidForWorkAppConfigurationSchema androidForWorkAppConfigurationSchemaToCreate);        /// <summary>
        /// Creates the specified AndroidForWorkAppConfigurationSchema using POST.
        /// </summary>
        /// <param name="androidForWorkAppConfigurationSchemaToCreate">The AndroidForWorkAppConfigurationSchema to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidForWorkAppConfigurationSchema> CreateAsync(AndroidForWorkAppConfigurationSchema androidForWorkAppConfigurationSchemaToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidForWorkAppConfigurationSchema.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidForWorkAppConfigurationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkAppConfigurationSchema.
        /// </summary>
        /// <returns>The AndroidForWorkAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidForWorkAppConfigurationSchema> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkAppConfigurationSchema.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidForWorkAppConfigurationSchema> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkAppConfigurationSchema using PATCH.
        /// </summary>
        /// <param name="androidForWorkAppConfigurationSchemaToUpdate">The AndroidForWorkAppConfigurationSchema to update.</param>
        /// <returns>The updated AndroidForWorkAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidForWorkAppConfigurationSchema> UpdateAsync(AndroidForWorkAppConfigurationSchema androidForWorkAppConfigurationSchemaToUpdate);

        /// <summary>
        /// Updates the specified AndroidForWorkAppConfigurationSchema using PATCH.
        /// </summary>
        /// <param name="androidForWorkAppConfigurationSchemaToUpdate">The AndroidForWorkAppConfigurationSchema to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkAppConfigurationSchema.</returns>
        System.Threading.Tasks.Task<AndroidForWorkAppConfigurationSchema> UpdateAsync(AndroidForWorkAppConfigurationSchema androidForWorkAppConfigurationSchemaToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkAppConfigurationSchemaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkAppConfigurationSchemaRequest Expand(Expression<Func<AndroidForWorkAppConfigurationSchema, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkAppConfigurationSchemaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkAppConfigurationSchemaRequest Select(Expression<Func<AndroidForWorkAppConfigurationSchema, object>> selectExpression);

    }
}
