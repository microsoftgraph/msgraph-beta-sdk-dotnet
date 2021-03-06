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
    /// The type Mobile App Policy Set Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppPolicySetItem : PolicySetItem
    {
    
		///<summary>
		/// The MobileAppPolicySetItem constructor
		///</summary>
        public MobileAppPolicySetItem()
        {
            this.ODataType = "microsoft.graph.mobileAppPolicySetItem";
        }
	
        /// <summary>
        /// Gets or sets intent.
        /// Install intent of the MobileAppPolicySetItem. Possible values are: available, required, uninstall, availableWithoutEnrollment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intent", Required = Newtonsoft.Json.Required.Default)]
        public InstallIntent? Intent { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// Settings of the MobileAppPolicySetItem.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public MobileAppAssignmentSettings Settings { get; set; }
    
    }
}

