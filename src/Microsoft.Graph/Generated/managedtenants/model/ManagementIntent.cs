// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Management Intent.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagementIntent : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The ManagementIntent constructor
		///</summary>
        public ManagementIntent()
        {
            this.ODataType = "microsoft.graph.managedTenants.managementIntent";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is global.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isGlobal", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsGlobal { get; set; }
    
        /// <summary>
        /// Gets or sets management templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementTemplates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ManagementTemplateDetailedInfo> ManagementTemplates { get; set; }
    
    }
}

