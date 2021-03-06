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
    /// The interface IUserAppConsentRequestsForApprovalCollectionRequestBuilder.
    /// </summary>
    public partial interface IUserAppConsentRequestsForApprovalCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IUserAppConsentRequestsForApprovalCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAppConsentRequestRequestBuilder"/> for the specified AppConsentRequest.
        /// </summary>
        /// <param name="id">The ID for the AppConsentRequest.</param>
        /// <returns>The <see cref="IAppConsentRequestRequestBuilder"/>.</returns>
        IAppConsentRequestRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for AppConsentRequestFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IAppConsentRequestFilterByCurrentUserRequestBuilder"/>.</returns>
        IAppConsentRequestFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            ConsentRequestFilterByCurrentUserOptions on);
    }
}
