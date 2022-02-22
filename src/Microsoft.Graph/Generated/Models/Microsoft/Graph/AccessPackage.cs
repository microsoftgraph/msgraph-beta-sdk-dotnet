using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessPackage : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessPackageCatalog AccessPackageCatalog { get; set; }
        /// <summary>Nullable.</summary>
        public List<AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes { get; set; }
        /// <summary>The access packages that are incompatible with this package. Read-only.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage> AccessPackagesIncompatibleWith { get; set; }
        /// <summary>Identifier of the access package catalog referencing this access package. Read-only.</summary>
        public string CatalogId { get; set; }
        /// <summary>The userPrincipalName of the user or identity of the subject who created this resource. Read-only.</summary>
        public string CreatedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the access package.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the access package. Supports $filter (eq, contains).</summary>
        public string DisplayName { get; set; }
        /// <summary>The  access packages whose assigned users are ineligible to be assigned this access package.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage> IncompatibleAccessPackages { get; set; }
        /// <summary>The groups whose members are ineligible to be assigned this access package.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.Group> IncompatibleGroups { get; set; }
        /// <summary>Whether the access package is hidden from the requestor.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>Indicates whether role scopes are visible.</summary>
        public bool? IsRoleScopesVisible { get; set; }
        /// <summary>The userPrincipalName of the user who last modified this resource. Read-only.</summary>
        public string ModifiedBy { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignmentPolicies", (o,n) => { (o as AccessPackage).AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>().ToList(); } },
                {"accessPackageCatalog", (o,n) => { (o as AccessPackage).AccessPackageCatalog = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageCatalog>(); } },
                {"accessPackageResourceRoleScopes", (o,n) => { (o as AccessPackage).AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>().ToList(); } },
                {"accessPackagesIncompatibleWith", (o,n) => { (o as AccessPackage).AccessPackagesIncompatibleWith = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>().ToList(); } },
                {"catalogId", (o,n) => { (o as AccessPackage).CatalogId = n.GetStringValue(); } },
                {"createdBy", (o,n) => { (o as AccessPackage).CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as AccessPackage).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as AccessPackage).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackage).DisplayName = n.GetStringValue(); } },
                {"incompatibleAccessPackages", (o,n) => { (o as AccessPackage).IncompatibleAccessPackages = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>().ToList(); } },
                {"incompatibleGroups", (o,n) => { (o as AccessPackage).IncompatibleGroups = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Group>().ToList(); } },
                {"isHidden", (o,n) => { (o as AccessPackage).IsHidden = n.GetBoolValue(); } },
                {"isRoleScopesVisible", (o,n) => { (o as AccessPackage).IsRoleScopesVisible = n.GetBoolValue(); } },
                {"modifiedBy", (o,n) => { (o as AccessPackage).ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackage).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicies", AccessPackageAssignmentPolicies);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageCatalog>("accessPackageCatalog", AccessPackageCatalog);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRoleScope>("accessPackageResourceRoleScopes", AccessPackageResourceRoleScopes);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>("accessPackagesIncompatibleWith", AccessPackagesIncompatibleWith);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>("incompatibleAccessPackages", IncompatibleAccessPackages);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Group>("incompatibleGroups", IncompatibleGroups);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteBoolValue("isRoleScopesVisible", IsRoleScopesVisible);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
