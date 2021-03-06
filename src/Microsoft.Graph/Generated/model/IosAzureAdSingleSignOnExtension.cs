// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IosAzureAdSingleSignOnExtension.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosAzureAdSingleSignOnExtension : IosSingleSignOnExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosAzureAdSingleSignOnExtension"/> class.
        /// </summary>
        public IosAzureAdSingleSignOnExtension()
        {
            this.ODataType = "microsoft.graph.iosAzureAdSingleSignOnExtension";
        }

        /// <summary>
        /// Gets or sets bundleIdAccessControlList.
        /// An optional list of additional bundle IDs allowed to use the AAD extension for single sign-on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bundleIdAccessControlList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BundleIdAccessControlList { get; set; }
    
        /// <summary>
        /// Gets or sets configurations.
        /// Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyTypedValuePair> Configurations { get; set; }
    
        /// <summary>
        /// Gets or sets enableSharedDeviceMode.
        /// Enables or disables shared device mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableSharedDeviceMode", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableSharedDeviceMode { get; set; }
    
    }
}
