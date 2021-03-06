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
    /// The type Play Prompt Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlayPromptOperation : CommsOperation
    {
    
		///<summary>
		/// The PlayPromptOperation constructor
		///</summary>
        public PlayPromptOperation()
        {
            this.ODataType = "microsoft.graph.playPromptOperation";
        }
	
        /// <summary>
        /// Gets or sets completion reason.
        /// Possible values are: unknown, completedSuccessfully, mediaOperationCanceled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completionReason", Required = Newtonsoft.Json.Required.Default)]
        public PlayPromptCompletionReason? CompletionReason { get; set; }
    
    }
}

