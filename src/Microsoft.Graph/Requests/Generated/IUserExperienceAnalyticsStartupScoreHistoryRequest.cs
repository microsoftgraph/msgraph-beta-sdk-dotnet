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
    /// The interface IUserExperienceAnalyticsStartupScoreHistoryRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsStartupScoreHistoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsStartupScoreHistory using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsStartupScoreHistoryToCreate">The UserExperienceAnalyticsStartupScoreHistory to create.</param>
        /// <returns>The created UserExperienceAnalyticsStartupScoreHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsStartupScoreHistory> CreateAsync(UserExperienceAnalyticsStartupScoreHistory userExperienceAnalyticsStartupScoreHistoryToCreate);        /// <summary>
        /// Creates the specified UserExperienceAnalyticsStartupScoreHistory using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsStartupScoreHistoryToCreate">The UserExperienceAnalyticsStartupScoreHistory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsStartupScoreHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsStartupScoreHistory> CreateAsync(UserExperienceAnalyticsStartupScoreHistory userExperienceAnalyticsStartupScoreHistoryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsStartupScoreHistory.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsStartupScoreHistory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsStartupScoreHistory.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsStartupScoreHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsStartupScoreHistory> GetAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsStartupScoreHistory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsStartupScoreHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsStartupScoreHistory> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsStartupScoreHistory using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsStartupScoreHistoryToUpdate">The UserExperienceAnalyticsStartupScoreHistory to update.</param>
        /// <returns>The updated UserExperienceAnalyticsStartupScoreHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsStartupScoreHistory> UpdateAsync(UserExperienceAnalyticsStartupScoreHistory userExperienceAnalyticsStartupScoreHistoryToUpdate);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsStartupScoreHistory using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsStartupScoreHistoryToUpdate">The UserExperienceAnalyticsStartupScoreHistory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsStartupScoreHistory.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsStartupScoreHistory> UpdateAsync(UserExperienceAnalyticsStartupScoreHistory userExperienceAnalyticsStartupScoreHistoryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsStartupScoreHistoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsStartupScoreHistoryRequest Expand(Expression<Func<UserExperienceAnalyticsStartupScoreHistory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsStartupScoreHistoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsStartupScoreHistoryRequest Select(Expression<Func<UserExperienceAnalyticsStartupScoreHistory, object>> selectExpression);

    }
}