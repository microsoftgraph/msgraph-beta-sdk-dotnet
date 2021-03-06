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
    /// The type Cloud Pc Audit Event.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CloudPcAuditEvent : Entity
    {
    
		///<summary>
		/// The CloudPcAuditEvent constructor
		///</summary>
        public CloudPcAuditEvent()
        {
            this.ODataType = "microsoft.graph.cloudPcAuditEvent";
        }
	
        /// <summary>
        /// Gets or sets activity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activity", Required = Newtonsoft.Json.Required.Default)]
        public string Activity { get; set; }
    
        /// <summary>
        /// Gets or sets activity date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets activity operation type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityOperationType", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcAuditActivityOperationType? ActivityOperationType { get; set; }
    
        /// <summary>
        /// Gets or sets activity result.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityResult", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcAuditActivityResult? ActivityResult { get; set; }
    
        /// <summary>
        /// Gets or sets activity type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityType", Required = Newtonsoft.Json.Required.Default)]
        public string ActivityType { get; set; }
    
        /// <summary>
        /// Gets or sets actor.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actor", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcAuditActor Actor { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcAuditCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets component name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "componentName", Required = Newtonsoft.Json.Required.Default)]
        public string ComponentName { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "correlationId", Required = Newtonsoft.Json.Required.Default)]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resources", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<CloudPcAuditResource> Resources { get; set; }
    
    }
}

