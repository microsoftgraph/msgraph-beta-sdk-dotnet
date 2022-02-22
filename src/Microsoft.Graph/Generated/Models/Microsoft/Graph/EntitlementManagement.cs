using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class EntitlementManagement : Entity, IParsable {
        public List<MicrosoftGraph.Models.Microsoft.Graph.Approval> AccessPackageAssignmentApprovals { get; set; }
        /// <summary>Represents the policy that governs which subjects can request or be assigned an access package via an access package assignment.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy> AccessPackageAssignmentPolicies { get; set; }
        /// <summary>Represents access package assignment requests created by or on behalf of a user.</summary>
        public List<AccessPackageAssignmentRequest> AccessPackageAssignmentRequests { get; set; }
        /// <summary>Represents the resource-specific role which a subject has been assigned through an access package assignment.</summary>
        public List<AccessPackageAssignmentResourceRole> AccessPackageAssignmentResourceRoles { get; set; }
        /// <summary>Represents the grant of an access package to a subject (user or group).</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment> AccessPackageAssignments { get; set; }
        /// <summary>Represents a group of access packages.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageCatalog> AccessPackageCatalogs { get; set; }
        /// <summary>A reference to the geolocation environment in which a resource is located.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceEnvironment> AccessPackageResourceEnvironments { get; set; }
        /// <summary>Represents a request to add or remove a resource to or from a catalog respectively.</summary>
        public List<AccessPackageResourceRequest> AccessPackageResourceRequests { get; set; }
        /// <summary>A reference to both a scope within a resource, and a role in that resource for that scope.</summary>
        public List<AccessPackageResourceRoleScope> AccessPackageResourceRoleScopes { get; set; }
        /// <summary>A reference to a resource associated with an access package catalog.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource> AccessPackageResources { get; set; }
        /// <summary>Represents access package objects.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage> AccessPackages { get; set; }
        /// <summary>Represents references to a directory or domain of another organization whose users can request access.</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.ConnectedOrganization> ConnectedOrganizations { get; set; }
        /// <summary>Represents the settings that control the behavior of Azure AD entitlement management.</summary>
        public EntitlementManagementSettings Settings { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackageAssignmentApprovals", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentApprovals = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Approval>().ToList(); } },
                {"accessPackageAssignmentPolicies", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentPolicies = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>().ToList(); } },
                {"accessPackageAssignmentRequests", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentRequests = n.GetCollectionOfObjectValues<AccessPackageAssignmentRequest>().ToList(); } },
                {"accessPackageAssignmentResourceRoles", (o,n) => { (o as EntitlementManagement).AccessPackageAssignmentResourceRoles = n.GetCollectionOfObjectValues<AccessPackageAssignmentResourceRole>().ToList(); } },
                {"accessPackageAssignments", (o,n) => { (o as EntitlementManagement).AccessPackageAssignments = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment>().ToList(); } },
                {"accessPackageCatalogs", (o,n) => { (o as EntitlementManagement).AccessPackageCatalogs = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageCatalog>().ToList(); } },
                {"accessPackageResourceEnvironments", (o,n) => { (o as EntitlementManagement).AccessPackageResourceEnvironments = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceEnvironment>().ToList(); } },
                {"accessPackageResourceRequests", (o,n) => { (o as EntitlementManagement).AccessPackageResourceRequests = n.GetCollectionOfObjectValues<AccessPackageResourceRequest>().ToList(); } },
                {"accessPackageResourceRoleScopes", (o,n) => { (o as EntitlementManagement).AccessPackageResourceRoleScopes = n.GetCollectionOfObjectValues<AccessPackageResourceRoleScope>().ToList(); } },
                {"accessPackageResources", (o,n) => { (o as EntitlementManagement).AccessPackageResources = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource>().ToList(); } },
                {"accessPackages", (o,n) => { (o as EntitlementManagement).AccessPackages = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>().ToList(); } },
                {"connectedOrganizations", (o,n) => { (o as EntitlementManagement).ConnectedOrganizations = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.ConnectedOrganization>().ToList(); } },
                {"settings", (o,n) => { (o as EntitlementManagement).Settings = n.GetObjectValue<EntitlementManagementSettings>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.Approval>("accessPackageAssignmentApprovals", AccessPackageAssignmentApprovals);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignmentPolicy>("accessPackageAssignmentPolicies", AccessPackageAssignmentPolicies);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentRequest>("accessPackageAssignmentRequests", AccessPackageAssignmentRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageAssignmentResourceRole>("accessPackageAssignmentResourceRoles", AccessPackageAssignmentResourceRoles);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageAssignment>("accessPackageAssignments", AccessPackageAssignments);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageCatalog>("accessPackageCatalogs", AccessPackageCatalogs);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResourceEnvironment>("accessPackageResourceEnvironments", AccessPackageResourceEnvironments);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRequest>("accessPackageResourceRequests", AccessPackageResourceRequests);
            writer.WriteCollectionOfObjectValues<AccessPackageResourceRoleScope>("accessPackageResourceRoleScopes", AccessPackageResourceRoleScopes);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackageResource>("accessPackageResources", AccessPackageResources);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.AccessPackage>("accessPackages", AccessPackages);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.ConnectedOrganization>("connectedOrganizations", ConnectedOrganizations);
            writer.WriteObjectValue<EntitlementManagementSettings>("settings", Settings);
        }
    }
}
