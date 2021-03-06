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
    /// The type Participant Left Notification.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ParticipantLeftNotification : Entity
    {
    
		///<summary>
		/// The ParticipantLeftNotification constructor
		///</summary>
        public ParticipantLeftNotification()
        {
            this.ODataType = "microsoft.graph.participantLeftNotification";
        }
	
        /// <summary>
        /// Gets or sets participant id.
        /// ID of the participant under the policy who has left the meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participantId", Required = Newtonsoft.Json.Required.Default)]
        public string ParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets call.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "call", Required = Newtonsoft.Json.Required.Default)]
        public Call Call { get; set; }
    
    }
}

