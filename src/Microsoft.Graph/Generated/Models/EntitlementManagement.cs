using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class EntitlementManagement : Entity, IParsable {
        /// <summary>Approval stages for assignment requests.</summary>
        public List<Approval> AccessPackageAssignmentApprovals {
            get { return BackingStore?.Get<List<Approval>>(nameof(AccessPackageAssignmentApprovals)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentApprovals), value); }
        }
        /// <summary>Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.</summary>
        public List<AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies {
            get { return BackingStore?.Get<List<AccessPackageAssignmentPolicy>>(nameof(AccessPackageAssignmentPolicies)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentPolicies), value); }
        }
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
        public List<AccessPackageAssignmentRequest> AccessPackageAssignmentRequests {
            get { return BackingStore?.Get<List<AccessPackageAssignmentRequest>>(nameof(AccessPackageAssignmentRequests)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentRequests), value); }
        }
        /// <summary>Represents the resource-specific role which a subject has been assigned through an access package assignment.</summary>
        public List<AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles {
            get { return BackingStore?.Get<List<AccessPackageAssignmentResourceRole>>(nameof(AccessPackageAssignmentResourceRoles)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignmentResourceRoles), value); }
        }
        /// <summary>Represents the grant of an access package to a subject (user or group).</summary>
        public List<AccessPackageAssignment> AccessPackageAssignments {
            get { return BackingStore?.Get<List<AccessPackageAssignment>>(nameof(AccessPackageAssignments)); }
            set { BackingStore?.Set(nameof(AccessPackageAssignments), value); }
        }
        /// <summary>Represents a group of access packages.</summary>
        public List<AccessPackageCatalog> AccessPackageCatalogs {
            get { return BackingStore?.Get<List<AccessPackageCatalog>>(nameof(AccessPackageCatalogs)); }
            set { BackingStore?.Set(nameof(AccessPackageCatalogs), value); }
        }
        /// <summary>A reference to the geolocation environment in which a resource is located.</summary>
        public List<AccessPackageResourceEnvironment> AccessPackageResourceEnvironments {
            get { return BackingStore?.Get<List<AccessPackageResourceEnvironment>>(nameof(AccessPackageResourceEnvironments)); }
            set { BackingStore?.Set(nameof(AccessPackageResourceEnvironments), value); }
        }
        /// <summary>Represents a request to add or remove a resource to or from a catalog respectively.</summary>
        public List<AccessPackageResourceRequest> AccessPackageResourceRequests {
            get { return BackingStore?.Get<List<AccessPackageResourceRequest>>(nameof(AccessPackageResourceRequests)); }
            set { BackingStore?.Set(nameof(AccessPackageResourceRequests), value); }
        }
        /// <summary>A reference to both a scope within a resource, and a role in that resource for that scope.</summary>
        public List<AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes {
            get { return BackingStore?.Get<List<AccessPackageResourceRoleScope>>(nameof(AccessPackageResourceRoleScopes)); }
            set { BackingStore?.Set(nameof(AccessPackageResourceRoleScopes), value); }
        }
        /// <summary>A reference to a resource associated with an access package catalog.</summary>
        public List<AccessPackageResource> AccessPackageResources {
            get { return BackingStore?.Get<List<AccessPackageResource>>(nameof(AccessPackageResources)); }
            set { BackingStore?.Set(nameof(AccessPackageResources), value); }
        }
        /// <summary>Represents access package objects.</summary>
        public List<AccessPackage> AccessPackages {
            get { return BackingStore?.Get<List<AccessPackage>>(nameof(AccessPackages)); }
            set { BackingStore?.Set(nameof(AccessPackages), value); }
        }
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
        public List<ConnectedOrganization> ConnectedOrganizations {
            get { return BackingStore?.Get<List<ConnectedOrganization>>(nameof(ConnectedOrganizations)); }
            set { BackingStore?.Set(nameof(ConnectedOrganizations), value); }
        }
        /// <summary>Represents the settings that control the behavior of Azure AD entitlement management.</summary>
        public EntitlementManagementSettings Settings {
            get { return BackingStore?.Get<EntitlementManagementSettings>(nameof(Settings)); }
            set { BackingStore?.Set(nameof(Settings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EntitlementManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackageAssignmentApprovals", n => { AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignmentPolicies", n => { AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignmentRequests", n => { AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignmentResourceRoles", n => { AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>(AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignments", n => { AccessPackageAssignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageCatalogs", n => { AccessPackageCatalogs = n.GetCollectionOfObjectValues<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceEnvironments", n => { AccessPackageResourceEnvironments = n.GetCollectionOfObjectValues<AccessPackageResourceEnvironment>(AccessPackageResourceEnvironment.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceRequests", n => { AccessPackageResourceRequests = n.GetCollectionOfObjectValues<AccessPackageResourceRequest>(AccessPackageResourceRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceRoleScopes", n => { AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>(AccessPackageResourceRoleScope.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResources", n => { AccessPackageResources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackages", n => { AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"connectedOrganizations", n => { ConnectedOrganizations = n.GetCollectionOfObjectValues<ConnectedOrganization>(ConnectedOrganization.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<EntitlementManagementSettings>(EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicies", AccessPackageAssignmentPolicies);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("accessPackageAssignmentRequests", AccessPackageAssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentResourceRole>("accessPackageAssignmentResourceRoles", AccessPackageAssignmentResourceRoles);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignment>("accessPackageAssignments", AccessPackageAssignments);
            writer.WriteCollectionOfObjectValues<AccessPackageCatalog>("accessPackageCatalogs", AccessPackageCatalogs);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceEnvironment>("accessPackageResourceEnvironments", AccessPackageResourceEnvironments);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRequest>("accessPackageResourceRequests", AccessPackageResourceRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRoleScope>("accessPackageResourceRoleScopes", AccessPackageResourceRoleScopes);
            writer.WriteCollectionOfObjectValues<AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteCollectionOfObjectValues<AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<EntitlementManagementSettings>("settings", Settings);
        }
    }
}
