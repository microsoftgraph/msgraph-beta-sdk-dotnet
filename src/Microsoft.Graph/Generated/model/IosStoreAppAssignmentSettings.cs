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
    /// The type IosStoreAppAssignmentSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosStoreAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosStoreAppAssignmentSettings"/> class.
        /// </summary>
        public IosStoreAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.iosStoreAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets isRemovable.
        /// Whether or not the app can be removed by the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isRemovable", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsRemovable { get; set; }
    
        /// <summary>
        /// Gets or sets uninstallOnDeviceRemoval.
        /// Whether or not to uninstall the app when device is removed from Intune.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uninstallOnDeviceRemoval", Required = Newtonsoft.Json.Required.Default)]
        public bool? UninstallOnDeviceRemoval { get; set; }
    
        /// <summary>
        /// Gets or sets vpnConfigurationId.
        /// The VPN Configuration Id to apply for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vpnConfigurationId", Required = Newtonsoft.Json.Required.Default)]
        public string VpnConfigurationId { get; set; }
    
    }
}
