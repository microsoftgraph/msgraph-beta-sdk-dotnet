// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type On Premises Publishing Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OnPremisesPublishingProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets hybrid agent updater configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hybridAgentUpdaterConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public HybridAgentUpdaterConfiguration HybridAgentUpdaterConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets agents.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agents", Required = Newtonsoft.Json.Required.Default)]
        public IOnPremisesPublishingProfileAgentsCollectionPage Agents { get; set; }
    
        /// <summary>
        /// Gets or sets agent groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agentGroups", Required = Newtonsoft.Json.Required.Default)]
        public IOnPremisesPublishingProfileAgentGroupsCollectionPage AgentGroups { get; set; }
    
        /// <summary>
        /// Gets or sets published resources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publishedResources", Required = Newtonsoft.Json.Required.Default)]
        public IOnPremisesPublishingProfilePublishedResourcesCollectionPage PublishedResources { get; set; }
    
    }
}
