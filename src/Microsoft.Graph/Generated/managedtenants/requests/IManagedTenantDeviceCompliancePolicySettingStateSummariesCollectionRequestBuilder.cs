// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedTenantDeviceCompliancePolicySettingStateSummariesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceCompliancePolicySettingStateSummaryRequestBuilder"/> for the specified DeviceCompliancePolicySettingStateSummary.
        /// </summary>
        /// <param name="id">The ID for the DeviceCompliancePolicySettingStateSummary.</param>
        /// <returns>The <see cref="IDeviceCompliancePolicySettingStateSummaryRequestBuilder"/>.</returns>
        IDeviceCompliancePolicySettingStateSummaryRequestBuilder this[string id] { get; }

        
    }
}
