using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageCatalog : Entity, IParsable {
        /// <summary>The roles in each resource in a catalog. Read-only.</summary>
        public List<AccessPackageResourceRole> AccessPackageResourceRoles { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<AccessPackageResource> AccessPackageResources { get; set; }
        /// <summary>Read-only.</summary>
        public List<AccessPackageResourceScope> AccessPackageResourceScopes { get; set; }
        /// <summary>The access packages in this catalog. Read-only. Nullable. Supports $expand.</summary>
        public List<AccessPackage> AccessPackages { get; set; }
        /// <summary>Has the value Published if the access packages are available for management.</summary>
        public string CatalogStatus { get; set; }
        /// <summary>One of UserManaged or ServiceDefault.</summary>
        public string CatalogType { get; set; }
        /// <summary>UPN of the user who created this resource. Read-only.</summary>
        public string CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The customAccessPackageWorkflowExtensions property</summary>
        public List<CustomAccessPackageWorkflowExtension> CustomAccessPackageWorkflowExtensions { get; set; }
        /// <summary>The description of the access package catalog.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the access package catalog. Supports $filter (eq, contains).</summary>
        public string DisplayName { get; set; }
        /// <summary>Whether the access packages in this catalog can be requested by users outside of the tenant.</summary>
        public bool? IsExternallyVisible { get; set; }
        /// <summary>The UPN of the user who last modified this resource. Read-only.</summary>
        public string ModifiedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageCatalog CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageCatalog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageResourceRoles", n => { AccessPackageResourceRoles = n.GetCollectionOfObjectValues<AccessPackageResourceRole>(AccessPackageResourceRole.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResources", n => { AccessPackageResources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceScopes", n => { AccessPackageResourceScopes = n.GetCollectionOfObjectValues<AccessPackageResourceScope>(AccessPackageResourceScope.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"catalogStatus", n => { CatalogStatus = n.GetStringValue(); } },
                {"catalogType", n => { CatalogType = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customAccessPackageWorkflowExtensions", n => { CustomAccessPackageWorkflowExtensions = n.GetCollectionOfObjectValues<CustomAccessPackageWorkflowExtension>(CustomAccessPackageWorkflowExtension.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isExternallyVisible", n => { IsExternallyVisible = n.GetBoolValue(); } },
                {"modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRole>("accessPackageResourceRoles", AccessPackageResourceRoles);
            writer.WriteCollectionOfObjectValues<AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceScope>("accessPackageResourceScopes", AccessPackageResourceScopes);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackages", AccessPackages);
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
