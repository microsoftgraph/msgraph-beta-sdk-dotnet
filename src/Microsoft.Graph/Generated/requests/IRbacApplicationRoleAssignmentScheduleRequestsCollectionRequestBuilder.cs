// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IRbacApplicationRoleAssignmentScheduleRequestsCollectionRequestBuilder.
    /// </summary>
    public partial interface IRbacApplicationRoleAssignmentScheduleRequestsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentScheduleRequestsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentScheduleRequestsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUnifiedRoleAssignmentScheduleRequestRequestBuilder"/> for the specified UnifiedRoleAssignmentScheduleRequest.
        /// </summary>
        /// <param name="id">The ID for the UnifiedRoleAssignmentScheduleRequest.</param>
        /// <returns>The <see cref="IUnifiedRoleAssignmentScheduleRequestRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentScheduleRequestRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for UnifiedRoleAssignmentScheduleRequestFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IUnifiedRoleAssignmentScheduleRequestFilterByCurrentUserRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentScheduleRequestFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            RoleAssignmentScheduleRequestFilterByCurrentUserOptions on);
    }
}
