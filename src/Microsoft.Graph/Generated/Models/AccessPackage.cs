using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessPackage : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
        public List<AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>>(nameof(AccessPackageAssignmentPolicies)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentPolicies), value); }
        }
        /// <summary>The accessPackageCatalog property</summary>
        public Microsoft.Graph.Beta.Models.AccessPackageCatalog AccessPackageCatalog {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageCatalog>(nameof(AccessPackageCatalog)); }
            set { BackingStore?.Set(nameof(AccessPackageCatalog), value); }
        }
        /// <summary>The accessPackageResourceRoleScopes property</summary>
        public List<AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceRoleScope>>(nameof(AccessPackageResourceRoleScopes)); }
            set { BackingStore?.Set(nameof(AccessPackageResourceRoleScopes), value); }
        }
        /// <summary>The access packages that are incompatible with this package. Read-only.</summary>
        public List<AccessPackage> AccessPackagesIncompatibleWith {
            get { return BackingStore?.Get<List<AccessPackage>>(nameof(AccessPackagesIncompatibleWith)); }
            set { BackingStore?.Set(nameof(AccessPackagesIncompatibleWith), value); }
        }
        /// <summary>Identifier of the access package catalog referencing this access package. Read-only.</summary>
        public string CatalogId {
            get { return BackingStore?.Get<string>(nameof(CatalogId)); }
            set { BackingStore?.Set(nameof(CatalogId), value); }
        }
        /// <summary>The userPrincipalName of the user or identity of the subject who created this resource. Read-only.</summary>
        public string CreatedBy {
            get { return BackingStore?.Get<string>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The description of the access package.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>The display name of the access package. Supports $filter (eq, contains).</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The  access packages whose assigned users are ineligible to be assigned this access package.</summary>
        public List<AccessPackage> IncompatibleAccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>(nameof(IncompatibleAccessPackages)); }
            set { BackingStore?.Set(nameof(IncompatibleAccessPackages), value); }
        }
        /// <summary>The groups whose members are ineligible to be assigned this access package.</summary>
        public List<Group> IncompatibleGroups {
            get { return BackingStore?.Get<List<Group>>(nameof(IncompatibleGroups)); }
            set { BackingStore?.Set(nameof(IncompatibleGroups), value); }
        }
        /// <summary>Whether the access package is hidden from the requestor.</summary>
        public bool? IsHidden {
            get { return BackingStore?.Get<bool?>(nameof(IsHidden)); }
            set { BackingStore?.Set(nameof(IsHidden), value); }
        }
        /// <summary>Indicates whether role scopes are visible.</summary>
        public bool? IsRoleScopesVisible {
            get { return BackingStore?.Get<bool?>(nameof(IsRoleScopesVisible)); }
            set { BackingStore?.Set(nameof(IsRoleScopesVisible), value); }
        }
        /// <summary>The userPrincipalName of the user who last modified this resource. Read-only.</summary>
        public string ModifiedBy {
            get { return BackingStore?.Get<string>(nameof(ModifiedBy)); }
            set { BackingStore?.Set(nameof(ModifiedBy), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ModifiedDateTime)); }
            set { BackingStore?.Set(nameof(ModifiedDateTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageAssignmentPolicies", n => { AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageCatalog", n => { AccessPackageCatalog = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageCatalog>(Microsoft.Graph.Beta.Models.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"accessPackageResourceRoleScopes", n => { AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>(AccessPackageResourceRoleScope.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackagesIncompatibleWith", n => { AccessPackagesIncompatibleWith = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"catalogId", n => { CatalogId = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"incompatibleAccessPackages", n => { IncompatibleAccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"incompatibleGroups", n => { IncompatibleGroups = n.GetCollectionOfObjectValues<Group>(Group.CreateFromDiscriminatorValue).ToList(); } },
                {"isHidden", n => { IsHidden = n.GetBoolValue(); } },
                {"isRoleScopesVisible", n => { IsRoleScopesVisible = n.GetBoolValue(); } },
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
