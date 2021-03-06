// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IRoleScopeTagWithReferenceRequestBuilder"/> for the specified RoleScopeTag.
        /// </summary>
        /// <param name="id">The ID for the RoleScopeTag.</param>
        /// <returns>The <see cref="IRoleScopeTagWithReferenceRequestBuilder"/>.</returns>
        IRoleScopeTagWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionReferencesRequestBuilder"/>.</returns>
        IDeviceAndAppManagementRoleAssignmentRoleScopeTagsCollectionReferencesRequestBuilder References { get; }

    }
}
