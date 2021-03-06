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
    /// The interface IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IManagedDeviceMobileAppConfigurationStateRequestBuilder"/> for the specified ManagedDeviceMobileAppConfigurationState.
        /// </summary>
        /// <param name="id">The ID for the ManagedDeviceMobileAppConfigurationState.</param>
        /// <returns>The <see cref="IManagedDeviceMobileAppConfigurationStateRequestBuilder"/>.</returns>
        IManagedDeviceMobileAppConfigurationStateRequestBuilder this[string id] { get; }

        
    }
}
