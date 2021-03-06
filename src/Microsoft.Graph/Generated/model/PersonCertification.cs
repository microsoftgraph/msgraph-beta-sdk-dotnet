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
    /// The type Person Certification.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PersonCertification : ItemFacet
    {
    
		///<summary>
		/// The PersonCertification constructor
		///</summary>
        public PersonCertification()
        {
            this.ODataType = "microsoft.graph.personCertification";
        }
	
        /// <summary>
        /// Gets or sets certification id.
        /// The referenceable identifier for the certification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificationId", Required = Newtonsoft.Json.Required.Default)]
        public string CertificationId { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the certification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Title of the certification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets end date.
        /// The date that the certification expires.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endDate", Required = Newtonsoft.Json.Required.Default)]
        public Date EndDate { get; set; }
    
        /// <summary>
        /// Gets or sets issued date.
        /// The date that the certification was issued.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuedDate", Required = Newtonsoft.Json.Required.Default)]
        public Date IssuedDate { get; set; }
    
        /// <summary>
        /// Gets or sets issuing authority.
        /// Authority which granted the certification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuingAuthority", Required = Newtonsoft.Json.Required.Default)]
        public string IssuingAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets issuing company.
        /// Company which granted the certification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuingCompany", Required = Newtonsoft.Json.Required.Default)]
        public string IssuingCompany { get; set; }
    
        /// <summary>
        /// Gets or sets start date.
        /// The date that the certification became valid.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDate", Required = Newtonsoft.Json.Required.Default)]
        public Date StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail url.
        /// URL referencing a thumbnail of the certification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "thumbnailUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ThumbnailUrl { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// URL referencing the certification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebUrl { get; set; }
    
    }
}

