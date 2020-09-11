// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IProfileCertificationsCollectionRequestBuilder.
    /// </summary>
    public partial interface IProfileCertificationsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IProfileCertificationsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IProfileCertificationsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPersonCertificationRequestBuilder"/> for the specified PersonCertification.
        /// </summary>
        /// <param name="id">The ID for the PersonCertification.</param>
        /// <returns>The <see cref="IPersonCertificationRequestBuilder"/>.</returns>
        IPersonCertificationRequestBuilder this[string id] { get; }

        
    }
}