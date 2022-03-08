using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of privilegedAccess entities.</summary>
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedAccess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as PrivilegedAccess).DisplayName = n.GetStringValue(); } },
                {"resources", (o,n) => { (o as PrivilegedAccess).Resources = n.GetCollectionOfObjectValues<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignmentRequests", (o,n) => { (o as PrivilegedAccess).RoleAssignmentRequests = n.GetCollectionOfObjectValues<GovernanceRoleAssignmentRequest>(GovernanceRoleAssignmentRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignments", (o,n) => { (o as PrivilegedAccess).RoleAssignments = n.GetCollectionOfObjectValues<GovernanceRoleAssignment>(GovernanceRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinitions", (o,n) => { (o as PrivilegedAccess).RoleDefinitions = n.GetCollectionOfObjectValues<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"roleSettings", (o,n) => { (o as PrivilegedAccess).RoleSettings = n.GetCollectionOfObjectValues<GovernanceRoleSetting>(GovernanceRoleSetting.CreateFromDiscriminatorValue).ToList(); } },
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
