using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackage : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>>("accessPackageAssignmentPolicies"); }
            set { BackingStore?.Set("accessPackageAssignmentPolicies", value); }
        }
        /// <summary>The accessPackageCatalog property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageCatalog AccessPackageCatalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageCatalog>("accessPackageCatalog"); }
            set { BackingStore?.Set("accessPackageCatalog", value); }
        }
        /// <summary>The accessPackageResourceRoleScopes property</summary>
        public List<AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceRoleScope>>("accessPackageResourceRoleScopes"); }
            set { BackingStore?.Set("accessPackageResourceRoleScopes", value); }
        }
        /// <summary>The access packages that are incompatible with this package. Read-only.</summary>
        public List<AccessPackage> AccessPackagesIncompatibleWith {
            get { return BackingStore?.Get<List<AccessPackage>>("accessPackagesIncompatibleWith"); }
            set { BackingStore?.Set("accessPackagesIncompatibleWith", value); }
        }
        /// <summary>Identifier of the access package catalog referencing this access package. Read-only.</summary>
        public string CatalogId {
            get { return BackingStore?.Get<string>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
        /// <summary>The userPrincipalName of the user or identity of the subject who created this resource. Read-only.</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the access package.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name of the access package. Supports $filter (eq, contains).</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The  access packages whose assigned users are ineligible to be assigned this access package.</summary>
        public List<AccessPackage> IncompatibleAccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>("incompatibleAccessPackages"); }
            set { BackingStore?.Set("incompatibleAccessPackages", value); }
        }
        /// <summary>The groups whose members are ineligible to be assigned this access package.</summary>
        public List<Group> IncompatibleGroups {
            get { return BackingStore?.Get<List<Group>>("incompatibleGroups"); }
            set { BackingStore?.Set("incompatibleGroups", value); }
        }
        /// <summary>Whether the access package is hidden from the requestor.</summary>
        public bool? IsHidden {
            get { return BackingStore?.Get<bool?>("isHidden"); }
            set { BackingStore?.Set("isHidden", value); }
        }
        /// <summary>Indicates whether role scopes are visible.</summary>
        public bool? IsRoleScopesVisible {
            get { return BackingStore?.Get<bool?>("isRoleScopesVisible"); }
            set { BackingStore?.Set("isRoleScopesVisible", value); }
        }
        /// <summary>The userPrincipalName of the user who last modified this resource. Read-only.</summary>
        public string ModifiedBy {
            get { return BackingStore?.Get<string>("modifiedBy"); }
            set { BackingStore?.Set("modifiedBy", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageAssignmentPolicies", n => { AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackageCatalog", n => { AccessPackageCatalog = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageCatalog>(Microsoft.Graph.Beta.Models.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceRoleScopes", n => { AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>(AccessPackageResourceRoleScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"accessPackagesIncompatibleWith", n => { AccessPackagesIncompatibleWith = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"catalogId", n => { CatalogId = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"incompatibleAccessPackages", n => { IncompatibleAccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"incompatibleGroups", n => { IncompatibleGroups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isHidden", n => { IsHidden = n.GetBoolValue(); } },
                {"isRoleScopesVisible", n => { IsRoleScopesVisible = n.GetBoolValue(); } },
                {"modifiedBy", n => { ModifiedBy = n.GetStringValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicies", AccessPackageAssignmentPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageCatalog>("accessPackageCatalog", AccessPackageCatalog);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRoleScope>("accessPackageResourceRoleScopes", AccessPackageResourceRoleScopes);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackagesIncompatibleWith", AccessPackagesIncompatibleWith);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<AccessPackage>("incompatibleAccessPackages", IncompatibleAccessPackages);
            writer.WriteCollectionOfObjectValues<Group>("incompatibleGroups", IncompatibleGroups);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteBoolValue("isRoleScopesVisible", IsRoleScopesVisible);
            writer.WriteStringValue("modifiedBy", ModifiedBy);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
        }
    }
}
