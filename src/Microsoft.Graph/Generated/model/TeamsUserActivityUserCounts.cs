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
    /// The type Teams User Activity User Counts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsUserActivityUserCounts : Entity
    {
    
		///<summary>
		/// The TeamsUserActivityUserCounts constructor
		///</summary>
        public TeamsUserActivityUserCounts()
        {
            this.ODataType = "microsoft.graph.teamsUserActivityUserCounts";
        }
	
        /// <summary>
        /// Gets or sets calls.
        /// The number of users who participated in 1:1 calls.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calls", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Calls { get; set; }
    
        /// <summary>
        /// Gets or sets meetings.
        /// The number of users who participated in online meetings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetings", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Meetings { get; set; }
    
        /// <summary>
        /// Gets or sets other actions.
        /// The number of users who were active but performed other activities than exposed action types offered in the report (sending or replying to channel messages and chat messages, scheduling or participating in 1:1 calls and meetings). Examples actions are when a user changes the Teams status or the Teams status message or opens a Channel Message post but does not reply.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "otherActions", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OtherActions { get; set; }
    
        /// <summary>
        /// Gets or sets private chat messages.
        /// The number of users who posted message in a private chat.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "privateChatMessages", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PrivateChatMessages { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// The date on which the users performed the activities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// The number of days the report covers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// The latest date of the content.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets team chat messages.
        /// The number of users who posted message in a team chat.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamChatMessages", Required = Newtonsoft.Json.Required.Default)]
        public Int64? TeamChatMessages { get; set; }
    
    }
}

