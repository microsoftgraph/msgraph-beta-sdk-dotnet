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
    /// The interface IDeviceManagementReusablePolicySettingReferencingConfigurationPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementReusablePolicySettingReferencingConfigurationPoliciesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementReusablePolicySettingReferencingConfigurationPoliciesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementReusablePolicySettingReferencingConfigurationPoliciesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceManagementConfigurationPolicyRequestBuilder"/> for the specified DeviceManagementConfigurationPolicy.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementConfigurationPolicy.</param>
        /// <returns>The <see cref="IDeviceManagementConfigurationPolicyRequestBuilder"/>.</returns>
        IDeviceManagementConfigurationPolicyRequestBuilder this[string id] { get; }

        
    }
}
