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
    /// The interface ICloudPcUserSettingAssignmentRequest.
    /// </summary>
    public partial interface ICloudPcUserSettingAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPcUserSettingAssignment using POST.
        /// </summary>
        /// <param name="cloudPcUserSettingAssignmentToCreate">The CloudPcUserSettingAssignment to create.</param>
        /// <returns>The created CloudPcUserSettingAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcUserSettingAssignment> CreateAsync(CloudPcUserSettingAssignment cloudPcUserSettingAssignmentToCreate);        /// <summary>
        /// Creates the specified CloudPcUserSettingAssignment using POST.
        /// </summary>
        /// <param name="cloudPcUserSettingAssignmentToCreate">The CloudPcUserSettingAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcUserSettingAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcUserSettingAssignment> CreateAsync(CloudPcUserSettingAssignment cloudPcUserSettingAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CloudPcUserSettingAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CloudPcUserSettingAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CloudPcUserSettingAssignment.
        /// </summary>
        /// <returns>The CloudPcUserSettingAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcUserSettingAssignment> GetAsync();

        /// <summary>
        /// Gets the specified CloudPcUserSettingAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcUserSettingAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcUserSettingAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CloudPcUserSettingAssignment using PATCH.
        /// </summary>
        /// <param name="cloudPcUserSettingAssignmentToUpdate">The CloudPcUserSettingAssignment to update.</param>
        /// <returns>The updated CloudPcUserSettingAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcUserSettingAssignment> UpdateAsync(CloudPcUserSettingAssignment cloudPcUserSettingAssignmentToUpdate);

        /// <summary>
        /// Updates the specified CloudPcUserSettingAssignment using PATCH.
        /// </summary>
        /// <param name="cloudPcUserSettingAssignmentToUpdate">The CloudPcUserSettingAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcUserSettingAssignment.</returns>
        System.Threading.Tasks.Task<CloudPcUserSettingAssignment> UpdateAsync(CloudPcUserSettingAssignment cloudPcUserSettingAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcUserSettingAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcUserSettingAssignmentRequest Expand(Expression<Func<CloudPcUserSettingAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcUserSettingAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcUserSettingAssignmentRequest Select(Expression<Func<CloudPcUserSettingAssignment, object>> selectExpression);

    }
}
