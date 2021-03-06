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
    /// The type Email File Assessment Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EmailFileAssessmentRequestObject : ThreatAssessmentRequestObject
    {
    
		///<summary>
		/// The EmailFileAssessmentRequest constructor
		///</summary>
        public EmailFileAssessmentRequestObject()
        {
            this.ODataType = "microsoft.graph.emailFileAssessmentRequest";
        }
	
        /// <summary>
        /// Gets or sets content data.
        /// Base64 encoded .eml email file content. The file content cannot fetch back because it isn't stored.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentData", Required = Newtonsoft.Json.Required.Default)]
        public string ContentData { get; set; }
    
        /// <summary>
        /// Gets or sets destination routing reason.
        /// The reason for mail routed to its destination. Possible values are: none, mailFlowRule, safeSender, blockedSender, advancedSpamFiltering, domainAllowList, domainBlockList, notInAddressBook, firstTimeSender, autoPurgeToInbox, autoPurgeToJunk, autoPurgeToDeleted, outbound, notJunk, junk.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationRoutingReason", Required = Newtonsoft.Json.Required.Default)]
        public MailDestinationRoutingReason? DestinationRoutingReason { get; set; }
    
        /// <summary>
        /// Gets or sets recipient email.
        /// The mail recipient whose policies are used to assess the mail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipientEmail", Required = Newtonsoft.Json.Required.Default)]
        public string RecipientEmail { get; set; }
    
    }
}

