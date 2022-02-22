using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackageCatalog : Entity, IParsable {
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceRole> AccessPackageResourceRoles { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource> AccessPackageResources { get; set; }
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceScope> AccessPackageResourceScopes { get; set; }
        /// <summary>The access packages in this catalog. Read-only. Nullable.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage> AccessPackages { get; set; }
        /// <summary>Has the value Published if the access packages are available for management.</summary>
        public string CatalogStatus { get; set; }
        /// <summary>Whether the catalog is created by a user or entitlement management. The possible values are: userManaged, serviceDefault, serviceManaged, unknownFutureValue.</summary>
        public string CatalogType { get; set; }
        /// <summary>UPN of the user who created this resource. Read-only.</summary>
        public string CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        public List<CustomAccessPackageWorkflowExtension> CustomAccessPackageWorkflowExtensions { get; set; }
        /// <summary>The description of the access package catalog.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the access package catalog.</summary>
        public string DisplayName { get; set; }
        /// <summary>Whether the access packages in this catalog can be requested by users outside of the tenant.</summary>
        public bool? IsExternallyVisible { get; set; }
        /// <summary>The UPN of the user who last modified this resource. Read-only.</summary>
        public string ModifiedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageResourceRoles", (o,n) => { (o as AccessPackageCatalog).AccessPackageResourceRoles = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceRole>().ToList(); } },
                {"accessPackageResources", (o,n) => { (o as AccessPackageCatalog).AccessPackageResources = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource>().ToList(); } },
                {"accessPackageResourceScopes", (o,n) => { (o as AccessPackageCatalog).AccessPackageResourceScopes = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceScope>().ToList(); } },
                {"accessPackages", (o,n) => { (o as AccessPackageCatalog).AccessPackages = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>().ToList(); } },
                {"catalogStatus", (o,n) => { (o as AccessPackageCatalog).CatalogStatus = n.GetStringValue(); } },
                {"catalogType", (o,n) => { (o as AccessPackageCatalog).CatalogType = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as AccessPackageCatalog).CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageCatalog).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customAccessPackageWorkflowExtensions", (o,n) => { (o as AccessPackageCatalog).CustomAccessPackageWorkflowExtensions = n.GetCollectionOfObjectValues<CustomAccessPackageWorkflowExtension>().ToList(); } },
                {"description", (o,n) => { (o as AccessPackageCatalog).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageCatalog).DisplayName = n.GetStringValue(); } },
                {"isExternallyVisible", (o,n) => { (o as AccessPackageCatalog).IsExternallyVisible = n.GetBoolValue(); } },
                {"modifiedBy", (o,n) => { (o as AccessPackageCatalog).ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackageCatalog).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceRole>("accessPackageResourceRoles", AccessPackageResourceRoles);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceScope>("accessPackageResourceScopes", AccessPackageResourceScopes);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>("accessPackages", AccessPackages);
            writer.WriteStringValue("catalogStatus", CatalogStatus);
            writer.WriteStringValue("catalogType", CatalogType);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<CustomAccessPackageWorkflowExtension>("customAccessPackageWorkflowExtensions", CustomAccessPackageWorkflowExtensions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isExternallyVisible", IsExternallyVisible);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
