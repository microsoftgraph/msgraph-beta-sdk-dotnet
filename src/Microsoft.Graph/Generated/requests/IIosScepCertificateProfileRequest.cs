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
    /// The interface IIosScepCertificateProfileRequest.
    /// </summary>
    public partial interface IIosScepCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosScepCertificateProfile using POST.
        /// </summary>
        /// <param name="iosScepCertificateProfileToCreate">The IosScepCertificateProfile to create.</param>
        /// <returns>The created IosScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosScepCertificateProfile> CreateAsync(IosScepCertificateProfile iosScepCertificateProfileToCreate);        /// <summary>
        /// Creates the specified IosScepCertificateProfile using POST.
        /// </summary>
        /// <param name="iosScepCertificateProfileToCreate">The IosScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosScepCertificateProfile> CreateAsync(IosScepCertificateProfile iosScepCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified IosScepCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified IosScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosScepCertificateProfile.
        /// </summary>
        /// <returns>The IosScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosScepCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified IosScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosScepCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosScepCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosScepCertificateProfileToUpdate">The IosScepCertificateProfile to update.</param>
        /// <returns>The updated IosScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosScepCertificateProfile> UpdateAsync(IosScepCertificateProfile iosScepCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified IosScepCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosScepCertificateProfileToUpdate">The IosScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosScepCertificateProfile> UpdateAsync(IosScepCertificateProfile iosScepCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosScepCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosScepCertificateProfileRequest Expand(Expression<Func<IosScepCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosScepCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosScepCertificateProfileRequest Select(Expression<Func<IosScepCertificateProfile, object>> selectExpression);

    }
}
