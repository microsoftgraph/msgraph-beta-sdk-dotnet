// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The interface IAccessPackageAssignmentFilterByCurrentUserCollectionPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<AccessPackageAssignmentFilterByCurrentUserCollectionPage>))]
    public interface IAccessPackageAssignmentFilterByCurrentUserCollectionPage : ICollectionPage<AccessPackageAssignment>
    {
        /// <summary>
        /// Gets the next page <see cref="IAccessPackageAssignmentFilterByCurrentUserRequest"/> instance.
        /// </summary>
        IAccessPackageAssignmentFilterByCurrentUserRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
