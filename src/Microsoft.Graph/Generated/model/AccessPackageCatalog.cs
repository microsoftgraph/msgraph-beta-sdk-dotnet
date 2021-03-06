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
    /// The type Access Package Catalog.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessPackageCatalog : Entity
    {
    
		///<summary>
		/// The AccessPackageCatalog constructor
		///</summary>
        public AccessPackageCatalog()
        {
            this.ODataType = "microsoft.graph.accessPackageCatalog";
        }
	
        /// <summary>
        /// Gets or sets catalog status.
        /// Has the value Published if the access packages are available for management.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "catalogStatus", Required = Newtonsoft.Json.Required.Default)]
        public string CatalogStatus { get; set; }
    
        /// <summary>
        /// Gets or sets catalog type.
        /// One of UserManaged or ServiceDefault.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "catalogType", Required = Newtonsoft.Json.Required.Default)]
        public string CatalogType { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// UPN of the user who created this resource. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public string CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the access package catalog.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the access package catalog.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is externally visible.
        /// Whether the access packages in this catalog can be requested by users outside of the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isExternallyVisible", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsExternallyVisible { get; set; }
    
        /// <summary>
        /// Gets or sets modified by.
        /// The UPN of the user who last modified this resource. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modifiedBy", Required = Newtonsoft.Json.Required.Default)]
        public string ModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets access package resource roles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessPackageResourceRoles", Required = Newtonsoft.Json.Required.Default)]
        public IAccessPackageCatalogAccessPackageResourceRolesCollectionPage AccessPackageResourceRoles { get; set; }
    
        /// <summary>
        /// Gets or sets access package resources.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessPackageResources", Required = Newtonsoft.Json.Required.Default)]
        public IAccessPackageCatalogAccessPackageResourcesCollectionPage AccessPackageResources { get; set; }
    
        /// <summary>
        /// Gets or sets access package resource scopes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessPackageResourceScopes", Required = Newtonsoft.Json.Required.Default)]
        public IAccessPackageCatalogAccessPackageResourceScopesCollectionPage AccessPackageResourceScopes { get; set; }
    
        /// <summary>
        /// Gets or sets access packages.
        /// The access packages in this catalog. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessPackages", Required = Newtonsoft.Json.Required.Default)]
        public IAccessPackageCatalogAccessPackagesCollectionPage AccessPackages { get; set; }
    
    }
}

