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
    /// The interface IUnifiedRoleManagementPolicyAuthenticationContextRuleRequest.
    /// </summary>
    public partial interface IUnifiedRoleManagementPolicyAuthenticationContextRuleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyAuthenticationContextRule using POST.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyAuthenticationContextRuleToCreate">The UnifiedRoleManagementPolicyAuthenticationContextRule to create.</param>
        /// <returns>The created UnifiedRoleManagementPolicyAuthenticationContextRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyAuthenticationContextRule> CreateAsync(UnifiedRoleManagementPolicyAuthenticationContextRule unifiedRoleManagementPolicyAuthenticationContextRuleToCreate);        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyAuthenticationContextRule using POST.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyAuthenticationContextRuleToCreate">The UnifiedRoleManagementPolicyAuthenticationContextRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleManagementPolicyAuthenticationContextRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyAuthenticationContextRule> CreateAsync(UnifiedRoleManagementPolicyAuthenticationContextRule unifiedRoleManagementPolicyAuthenticationContextRuleToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyAuthenticationContextRule.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyAuthenticationContextRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyAuthenticationContextRule.
        /// </summary>
        /// <returns>The UnifiedRoleManagementPolicyAuthenticationContextRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyAuthenticationContextRule> GetAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyAuthenticationContextRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleManagementPolicyAuthenticationContextRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyAuthenticationContextRule> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyAuthenticationContextRule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyAuthenticationContextRuleToUpdate">The UnifiedRoleManagementPolicyAuthenticationContextRule to update.</param>
        /// <returns>The updated UnifiedRoleManagementPolicyAuthenticationContextRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyAuthenticationContextRule> UpdateAsync(UnifiedRoleManagementPolicyAuthenticationContextRule unifiedRoleManagementPolicyAuthenticationContextRuleToUpdate);

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyAuthenticationContextRule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyAuthenticationContextRuleToUpdate">The UnifiedRoleManagementPolicyAuthenticationContextRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleManagementPolicyAuthenticationContextRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyAuthenticationContextRule> UpdateAsync(UnifiedRoleManagementPolicyAuthenticationContextRule unifiedRoleManagementPolicyAuthenticationContextRuleToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyAuthenticationContextRuleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyAuthenticationContextRuleRequest Expand(Expression<Func<UnifiedRoleManagementPolicyAuthenticationContextRule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyAuthenticationContextRuleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyAuthenticationContextRuleRequest Select(Expression<Func<UnifiedRoleManagementPolicyAuthenticationContextRule, object>> selectExpression);

    }
}
