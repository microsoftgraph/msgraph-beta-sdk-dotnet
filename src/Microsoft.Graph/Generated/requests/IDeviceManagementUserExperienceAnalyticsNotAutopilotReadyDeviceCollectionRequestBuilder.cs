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
    /// The interface IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder"/> for the specified UserExperienceAnalyticsNotAutopilotReadyDevice.
        /// </summary>
        /// <param name="id">The ID for the UserExperienceAnalyticsNotAutopilotReadyDevice.</param>
        /// <returns>The <see cref="IUserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsNotAutopilotReadyDeviceRequestBuilder this[string id] { get; }

        
    }
}
