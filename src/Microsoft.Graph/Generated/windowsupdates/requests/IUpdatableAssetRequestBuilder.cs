// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IUpdatableAssetRequestBuilder.
    /// </summary>
    public partial interface IUpdatableAssetRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IUpdatableAssetRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IUpdatableAssetRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for UpdatableAssetAddMembers.
        /// </summary>
        /// <returns>The <see cref="IUpdatableAssetAddMembersRequestBuilder"/>.</returns>
        IUpdatableAssetAddMembersRequestBuilder AddMembers(
            IEnumerable<UpdatableAsset> assets = null);

        /// <summary>
        /// Gets the request builder for UpdatableAssetAddMembersById.
        /// </summary>
        /// <returns>The <see cref="IUpdatableAssetAddMembersByIdRequestBuilder"/>.</returns>
        IUpdatableAssetAddMembersByIdRequestBuilder AddMembersById(
            IEnumerable<string> ids = null,
            string memberEntityType = null);

        /// <summary>
        /// Gets the request builder for UpdatableAssetRemoveMembers.
        /// </summary>
        /// <returns>The <see cref="IUpdatableAssetRemoveMembersRequestBuilder"/>.</returns>
        IUpdatableAssetRemoveMembersRequestBuilder RemoveMembers(
            IEnumerable<UpdatableAsset> assets = null);

        /// <summary>
        /// Gets the request builder for UpdatableAssetRemoveMembersById.
        /// </summary>
        /// <returns>The <see cref="IUpdatableAssetRemoveMembersByIdRequestBuilder"/>.</returns>
        IUpdatableAssetRemoveMembersByIdRequestBuilder RemoveMembersById(
            IEnumerable<string> ids = null,
            string memberEntityType = null);
    
    }
}
