// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Tenant Detailed Information.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TenantDetailedInformation : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The TenantDetailedInformation constructor
		///</summary>
        public TenantDetailedInformation()
        {
            this.ODataType = "microsoft.graph.managedTenants.tenantDetailedInformation";
        }
	
        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city", Required = Newtonsoft.Json.Required.Default)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets country code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryCode", Required = Newtonsoft.Json.Required.Default)]
        public string CountryCode { get; set; }
    
        /// <summary>
        /// Gets or sets country name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countryName", Required = Newtonsoft.Json.Required.Default)]
        public string CountryName { get; set; }
    
        /// <summary>
        /// Gets or sets default domain name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultDomainName", Required = Newtonsoft.Json.Required.Default)]
        public string DefaultDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets industry name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "industryName", Required = Newtonsoft.Json.Required.Default)]
        public string IndustryName { get; set; }
    
        /// <summary>
        /// Gets or sets region.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "region", Required = Newtonsoft.Json.Required.Default)]
        public string Region { get; set; }
    
        /// <summary>
        /// Gets or sets segment name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "segmentName", Required = Newtonsoft.Json.Required.Default)]
        public string SegmentName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets vertical name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "verticalName", Required = Newtonsoft.Json.Required.Default)]
        public string VerticalName { get; set; }
    
    }
}

