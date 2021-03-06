// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Management Configuration Simple Setting Definition.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementConfigurationSimpleSettingDefinition : DeviceManagementConfigurationSettingDefinition
    {
    
		///<summary>
		/// The DeviceManagementConfigurationSimpleSettingDefinition constructor
		///</summary>
        public DeviceManagementConfigurationSimpleSettingDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationSimpleSettingDefinition";
        }
	
        /// <summary>
        /// Gets or sets default value.
        /// Default setting value for this setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultValue", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementConfigurationSettingValue DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets depended on by.
        /// list of child settings that depend on this setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dependedOnBy", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy { get; set; }
    
        /// <summary>
        /// Gets or sets dependent on.
        /// list of parent settings this setting is dependent on
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dependentOn", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceManagementConfigurationDependentOn> DependentOn { get; set; }
    
        /// <summary>
        /// Gets or sets value definition.
        /// Definition of the value for this setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueDefinition", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementConfigurationSettingValueDefinition ValueDefinition { get; set; }
    
    }
}

