// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICloudPcDeviceRequest.
    /// </summary>
    public partial interface ICloudPcDeviceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPcDevice using POST.
        /// </summary>
        /// <param name="cloudPcDeviceToCreate">The CloudPcDevice to create.</param>
        /// <returns>The created CloudPcDevice.</returns>
        System.Threading.Tasks.Task<CloudPcDevice> CreateAsync(CloudPcDevice cloudPcDeviceToCreate);        /// <summary>
        /// Creates the specified CloudPcDevice using POST.
        /// </summary>
        /// <param name="cloudPcDeviceToCreate">The CloudPcDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcDevice.</returns>
        System.Threading.Tasks.Task<CloudPcDevice> CreateAsync(CloudPcDevice cloudPcDeviceToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CloudPcDevice.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CloudPcDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CloudPcDevice.
        /// </summary>
        /// <returns>The CloudPcDevice.</returns>
        System.Threading.Tasks.Task<CloudPcDevice> GetAsync();

        /// <summary>
        /// Gets the specified CloudPcDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcDevice.</returns>
        System.Threading.Tasks.Task<CloudPcDevice> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CloudPcDevice using PATCH.
        /// </summary>
        /// <param name="cloudPcDeviceToUpdate">The CloudPcDevice to update.</param>
        /// <returns>The updated CloudPcDevice.</returns>
        System.Threading.Tasks.Task<CloudPcDevice> UpdateAsync(CloudPcDevice cloudPcDeviceToUpdate);

        /// <summary>
        /// Updates the specified CloudPcDevice using PATCH.
        /// </summary>
        /// <param name="cloudPcDeviceToUpdate">The CloudPcDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcDevice.</returns>
        System.Threading.Tasks.Task<CloudPcDevice> UpdateAsync(CloudPcDevice cloudPcDeviceToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceRequest Expand(Expression<Func<CloudPcDevice, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceRequest Select(Expression<Func<CloudPcDevice, object>> selectExpression);

    }
}
