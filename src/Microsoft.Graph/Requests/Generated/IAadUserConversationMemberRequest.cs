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
    /// The interface IAadUserConversationMemberRequest.
    /// </summary>
    public partial interface IAadUserConversationMemberRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AadUserConversationMember using PUT.
        /// </summary>
        /// <param name="aadUserConversationMemberToCreate">The AadUserConversationMember to create.</param>
        /// <returns>The created AadUserConversationMember.</returns>
        System.Threading.Tasks.Task<AadUserConversationMember> CreateAsync(AadUserConversationMember aadUserConversationMemberToCreate);        /// <summary>
        /// Creates the specified AadUserConversationMember using PUT.
        /// </summary>
        /// <param name="aadUserConversationMemberToCreate">The AadUserConversationMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AadUserConversationMember.</returns>
        System.Threading.Tasks.Task<AadUserConversationMember> CreateAsync(AadUserConversationMember aadUserConversationMemberToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AadUserConversationMember.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AadUserConversationMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AadUserConversationMember.
        /// </summary>
        /// <returns>The AadUserConversationMember.</returns>
        System.Threading.Tasks.Task<AadUserConversationMember> GetAsync();

        /// <summary>
        /// Gets the specified AadUserConversationMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AadUserConversationMember.</returns>
        System.Threading.Tasks.Task<AadUserConversationMember> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AadUserConversationMember using PATCH.
        /// </summary>
        /// <param name="aadUserConversationMemberToUpdate">The AadUserConversationMember to update.</param>
        /// <returns>The updated AadUserConversationMember.</returns>
        System.Threading.Tasks.Task<AadUserConversationMember> UpdateAsync(AadUserConversationMember aadUserConversationMemberToUpdate);

        /// <summary>
        /// Updates the specified AadUserConversationMember using PATCH.
        /// </summary>
        /// <param name="aadUserConversationMemberToUpdate">The AadUserConversationMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AadUserConversationMember.</returns>
        System.Threading.Tasks.Task<AadUserConversationMember> UpdateAsync(AadUserConversationMember aadUserConversationMemberToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAadUserConversationMemberRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAadUserConversationMemberRequest Expand(Expression<Func<AadUserConversationMember, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAadUserConversationMemberRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAadUserConversationMemberRequest Select(Expression<Func<AadUserConversationMember, object>> selectExpression);

    }
}