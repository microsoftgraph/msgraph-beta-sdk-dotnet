// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceManagementExchangeOnPremisesPolicyRequestBuilder.
    /// </summary>
    public partial class DeviceManagementExchangeOnPremisesPolicyRequestBuilder : EntityRequestBuilder, IDeviceManagementExchangeOnPremisesPolicyRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceManagementExchangeOnPremisesPolicyRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementExchangeOnPremisesPolicyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceManagementExchangeOnPremisesPolicyRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceManagementExchangeOnPremisesPolicyRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementExchangeOnPremisesPolicyRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ConditionalAccessSettings.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesConditionalAccessSettingsRequestBuilder"/>.</returns>
        public IOnPremisesConditionalAccessSettingsRequestBuilder ConditionalAccessSettings
        {
            get
            {
                return new OnPremisesConditionalAccessSettingsRequestBuilder(this.AppendSegmentToRequestUrl("conditionalAccessSettings"), this.Client);
            }
        }
    
    }
}
