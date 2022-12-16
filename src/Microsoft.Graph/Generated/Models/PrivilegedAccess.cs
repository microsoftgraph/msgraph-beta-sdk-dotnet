using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of accessReviewDecision entities.
    /// </summary>
    public class PrivilegedAccess : Entity, IParsable {
        /// <summary>The display name of the provider managed by PIM.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>A collection of resources for the provider.</summary>
        public List<GovernanceResource> Resources {
            get { return BackingStore?.Get<List<GovernanceResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
        /// <summary>A collection of role assignment requests for the provider.</summary>
        public List<GovernanceRoleAssignmentRequest> RoleAssignmentRequests {
            get { return BackingStore?.Get<List<GovernanceRoleAssignmentRequest>>("roleAssignmentRequests"); }
            set { BackingStore?.Set("roleAssignmentRequests", value); }
        }
        /// <summary>A collection of role assignments for the provider.</summary>
        public List<GovernanceRoleAssignment> RoleAssignments {
            get { return BackingStore?.Get<List<GovernanceRoleAssignment>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
        /// <summary>A collection of role defintions for the provider.</summary>
        public List<GovernanceRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<GovernanceRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
        /// <summary>A collection of role settings for the provider.</summary>
        public List<GovernanceRoleSetting> RoleSettings {
            get { return BackingStore?.Get<List<GovernanceRoleSetting>>("roleSettings"); }
            set { BackingStore?.Set("roleSettings", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccess CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccess();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignmentRequests", n => { RoleAssignmentRequests = n.GetCollectionOfObjectValues<GovernanceRoleAssignmentRequest>(GovernanceRoleAssignmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<GovernanceRoleAssignment>(GovernanceRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleSettings", n => { RoleSettings = n.GetCollectionOfObjectValues<GovernanceRoleSetting>(GovernanceRoleSetting.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
