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
    /// The interface IAndroidForWorkImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidForWorkImportedPFXCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="androidForWorkImportedPFXCertificateProfileToCreate">The AndroidForWorkImportedPFXCertificateProfile to create.</param>
        /// <returns>The created AndroidForWorkImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkImportedPFXCertificateProfile> CreateAsync(AndroidForWorkImportedPFXCertificateProfile androidForWorkImportedPFXCertificateProfileToCreate);        /// <summary>
        /// Creates the specified AndroidForWorkImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="androidForWorkImportedPFXCertificateProfileToCreate">The AndroidForWorkImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkImportedPFXCertificateProfile> CreateAsync(AndroidForWorkImportedPFXCertificateProfile androidForWorkImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidForWorkImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidForWorkImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The AndroidForWorkImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkImportedPFXCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidForWorkImportedPFXCertificateProfileToUpdate">The AndroidForWorkImportedPFXCertificateProfile to update.</param>
        /// <returns>The updated AndroidForWorkImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkImportedPFXCertificateProfile> UpdateAsync(AndroidForWorkImportedPFXCertificateProfile androidForWorkImportedPFXCertificateProfileToUpdate);

        /// <summary>
        /// Updates the specified AndroidForWorkImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidForWorkImportedPFXCertificateProfileToUpdate">The AndroidForWorkImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkImportedPFXCertificateProfile> UpdateAsync(AndroidForWorkImportedPFXCertificateProfile androidForWorkImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkImportedPFXCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkImportedPFXCertificateProfileRequest Expand(Expression<Func<AndroidForWorkImportedPFXCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkImportedPFXCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkImportedPFXCertificateProfileRequest Select(Expression<Func<AndroidForWorkImportedPFXCertificateProfile, object>> selectExpression);

    }
}
