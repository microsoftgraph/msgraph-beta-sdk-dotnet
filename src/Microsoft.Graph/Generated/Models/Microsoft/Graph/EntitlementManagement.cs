using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EntitlementManagement : Entity, IParsable {
        public List<Approval> AccessPackageAssignmentApprovals { get; set; }
        /// <summary>Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.</summary>
        public List<AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies { get; set; }
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
        public List<AccessPackageAssignmentRequest> AccessPackageAssignmentRequests { get; set; }
        /// <summary>Represents the resource-specific role which a subject has been assigned through an access package assignment.</summary>
        public List<AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles { get; set; }
        /// <summary>Represents the grant of an access package to a subject (user or group).</summary>
        public List<AccessPackageAssignment> AccessPackageAssignments { get; set; }
        /// <summary>Represents a group of access packages.</summary>
        public List<AccessPackageCatalog> AccessPackageCatalogs { get; set; }
        /// <summary>A reference to the geolocation environment in which a resource is located.</summary>
        public List<AccessPackageResourceEnvironment> AccessPackageResourceEnvironments { get; set; }
        /// <summary>Represents a request to add or remove a resource to or from a catalog respectively.</summary>
        public List<AccessPackageResourceRequest> AccessPackageResourceRequests { get; set; }
        /// <summary>A reference to both a scope within a resource, and a role in that resource for that scope.</summary>
        public List<AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes { get; set; }
        /// <summary>A reference to a resource associated with an access package catalog.</summary>
        public List<AccessPackageResource> AccessPackageResources { get; set; }
        /// <summary>Represents access package objects.</summary>
        public List<AccessPackage> AccessPackages { get; set; }
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
        public List<ConnectedOrganization> ConnectedOrganizations { get; set; }
        /// <summary>Represents the settings that control the behavior of Azure AD entitlement management.</summary>
        public EntitlementManagementSettings Settings { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignmentApprovals", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignmentPolicies", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignmentRequests", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>(AccessPackageAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignmentResourceRoles", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>(AccessPackageAssignmentResourceRole.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageAssignments", (o,n) => { (o as EntitlementManagement).AccessPackageAssignments = n.GetCollectionOfObjectValues<AccessPackageAssignment>(AccessPackageAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageCatalogs", (o,n) => { (o as EntitlementManagement).AccessPackageCatalogs = n.GetCollectionOfObjectValues<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceEnvironments", (o,n) => { (o as EntitlementManagement).AccessPackageResourceEnvironments = n.GetCollectionOfObjectValues<AccessPackageResourceEnvironment>(AccessPackageResourceEnvironment.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceRequests", (o,n) => { (o as EntitlementManagement).AccessPackageResourceRequests = n.GetCollectionOfObjectValues<AccessPackageResourceRequest>(AccessPackageResourceRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResourceRoleScopes", (o,n) => { (o as EntitlementManagement).AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>(AccessPackageResourceRoleScope.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackageResources", (o,n) => { (o as EntitlementManagement).AccessPackageResources = n.GetCollectionOfObjectValues<AccessPackageResource>(AccessPackageResource.CreateFromDiscriminatorValue).ToList(); } },
                {"accessPackages", (o,n) => { (o as EntitlementManagement).AccessPackages = n.GetCollectionOfObjectValues<AccessPackage>(AccessPackage.CreateFromDiscriminatorValue).ToList(); } },
                {"connectedOrganizations", (o,n) => { (o as EntitlementManagement).ConnectedOrganizations = n.GetCollectionOfObjectValues<ConnectedOrganization>(ConnectedOrganization.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", (o,n) => { (o as EntitlementManagement).Settings = n.GetObjectValue<EntitlementManagementSettings>(EntitlementManagementSettings.CreateFromDiscriminatorValue); } },
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
