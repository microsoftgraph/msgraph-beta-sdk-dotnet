using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PrivilegedAccess : Entity, IParsable {
        /// <summary>The display name of the provider managed by PIM.</summary>
        public string DisplayName { get; set; }
        /// <summary>A collection of resources for the provider.</summary>
        public List<GovernanceResource> Resources { get; set; }
        /// <summary>A collection of role assignment requests for the provider.</summary>
        public List<GovernanceRoleAssignmentRequest> RoleAssignmentRequests { get; set; }
        /// <summary>A collection of role assignments for the provider.</summary>
        public List<GovernanceRoleAssignment> RoleAssignments { get; set; }
        /// <summary>A collection of role defintions for the provider.</summary>
        public List<GovernanceRoleDefinition> RoleDefinitions { get; set; }
        /// <summary>A collection of role settings for the provider.</summary>
        public List<GovernanceRoleSetting> RoleSettings { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as PrivilegedAccess).DisplayName = n.GetStringValue(); } },
                {"resources", (o,n) => { (o as PrivilegedAccess).Resources = n.GetCollectionOfObjectValues<GovernanceResource>().ToList(); } },
                {"roleAssignmentRequests", (o,n) => { (o as PrivilegedAccess).RoleAssignmentRequests = n.GetCollectionOfObjectValues<GovernanceRoleAssignmentRequest>().ToList(); } },
                {"roleAssignments", (o,n) => { (o as PrivilegedAccess).RoleAssignments = n.GetCollectionOfObjectValues<GovernanceRoleAssignment>().ToList(); } },
                {"roleDefinitions", (o,n) => { (o as PrivilegedAccess).RoleDefinitions = n.GetCollectionOfObjectValues<GovernanceRoleDefinition>().ToList(); } },
                {"roleSettings", (o,n) => { (o as PrivilegedAccess).RoleSettings = n.GetCollectionOfObjectValues<GovernanceRoleSetting>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<GovernanceResource>("resources", Resources);
            writer.WriteCollectionOfObjectValues<GovernanceRoleAssignmentRequest>("roleAssignmentRequests", RoleAssignmentRequests);
            writer.WriteCollectionOfObjectValues<GovernanceRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<GovernanceRoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteCollectionOfObjectValues<GovernanceRoleSetting>("roleSettings", RoleSettings);
        }
    }
}
