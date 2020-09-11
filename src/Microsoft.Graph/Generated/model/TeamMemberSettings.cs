// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type TeamMemberSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TeamMemberSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberSettings"/> class.
        /// </summary>
        public TeamMemberSettings()
        {
            this.ODataType = "microsoft.graph.teamMemberSettings";
        }

        /// <summary>
        /// Gets or sets allowAddRemoveApps.
        /// If set to true, members can add and remove apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowAddRemoveApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowAddRemoveApps { get; set; }
    
        /// <summary>
        /// Gets or sets allowCreatePrivateChannels.
        /// If set to true, members can add and update private channels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowCreatePrivateChannels", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowCreatePrivateChannels { get; set; }
    
        /// <summary>
        /// Gets or sets allowCreateUpdateChannels.
        /// If set to true, members can add and update channels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowCreateUpdateChannels", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowCreateUpdateChannels { get; set; }
    
        /// <summary>
        /// Gets or sets allowCreateUpdateRemoveConnectors.
        /// If set to true, members can add, update, and remove connectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowCreateUpdateRemoveConnectors", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowCreateUpdateRemoveConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets allowCreateUpdateRemoveTabs.
        /// If set to true, members can add, update, and remove tabs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowCreateUpdateRemoveTabs", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowCreateUpdateRemoveTabs { get; set; }
    
        /// <summary>
        /// Gets or sets allowDeleteChannels.
        /// If set to true, members can delete channels.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowDeleteChannels", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowDeleteChannels { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}