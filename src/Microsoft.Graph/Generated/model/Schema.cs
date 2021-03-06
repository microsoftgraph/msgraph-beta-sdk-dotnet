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
    /// The type Schema.
    /// </summary>
    [Obsolete("The OData type annotation for this entity is being deprecated by Aug 2021. Please strip the @odata.type annotations for this specific entity from your request payloads before the deprecation date.")]
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Schema : Entity
    {
    
		///<summary>
		/// The Schema constructor
		///</summary>
        public Schema()
        {
            this.ODataType = "microsoft.graph.schema";
        }
	
        /// <summary>
        /// Gets or sets base type.
        /// Must be set to microsoft.graph.externalItem. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "baseType", Required = Newtonsoft.Json.Required.Default)]
        public string BaseType { get; set; }
    
        /// <summary>
        /// Gets or sets properties.
        /// The properties defined for the items in the connection. The minimum number of properties is one, the maximum is 128.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "properties", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Property> Properties { get; set; }
    
    }
}

