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
    /// The type Synchronization Schema.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SynchronizationSchema : Entity
    {
    
		///<summary>
		/// The SynchronizationSchema constructor
		///</summary>
        public SynchronizationSchema()
        {
            this.ODataType = "microsoft.graph.synchronizationSchema";
        }
	
        /// <summary>
        /// Gets or sets synchronization rules.
        /// A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "synchronizationRules", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<SynchronizationRule> SynchronizationRules { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The version of the schema, updated automatically with every schema change.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets directories.
        /// Contains the collection of directories and all of their objects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directories", Required = Newtonsoft.Json.Required.Default)]
        public ISynchronizationSchemaDirectoriesCollectionPage Directories { get; set; }
    
    }
}

