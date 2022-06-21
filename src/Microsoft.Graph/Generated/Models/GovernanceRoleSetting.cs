using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of governanceResource entities.</summary>
    public class GovernanceRoleSetting : Entity, IParsable {
        /// <summary>The rule settings that are evaluated when an administrator tries to add an eligible role assignment.</summary>
        public List<GovernanceRuleSetting> AdminEligibleSettings {
            get { return BackingStore?.Get<List<GovernanceRuleSetting>>(nameof(AdminEligibleSettings)); }
            set { BackingStore?.Set(nameof(AdminEligibleSettings), value); }
        }
        /// <summary>The rule settings that are evaluated when an administrator tries to add a direct member role assignment.</summary>
        public List<GovernanceRuleSetting> AdminMemberSettings {
            get { return BackingStore?.Get<List<GovernanceRuleSetting>>(nameof(AdminMemberSettings)); }
            set { BackingStore?.Set(nameof(AdminMemberSettings), value); }
        }
        /// <summary>Read-only. Indicate if the roleSetting is a default roleSetting</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>(nameof(IsDefault)); }
            set { BackingStore?.Set(nameof(IsDefault), value); }
        }
        /// <summary>Read-only. The display name of the administrator who last updated the roleSetting.</summary>
        public string LastUpdatedBy {
            get { return BackingStore?.Get<string>(nameof(LastUpdatedBy)); }
            set { BackingStore?.Set(nameof(LastUpdatedBy), value); }
        }
        /// <summary>Read-only. The time when the role setting was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdatedDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdatedDateTime), value); }
        }
        /// <summary>Read-only. The associated resource for this role setting.</summary>
        public GovernanceResource Resource {
            get { return BackingStore?.Get<GovernanceResource>(nameof(Resource)); }
            set { BackingStore?.Set(nameof(Resource), value); }
        }
        /// <summary>Required. The id of the resource that the role setting is associated with.</summary>
        public string ResourceId {
            get { return BackingStore?.Get<string>(nameof(ResourceId)); }
            set { BackingStore?.Set(nameof(ResourceId), value); }
        }
        /// <summary>Read-only. The role definition that is enforced with this role setting.</summary>
        public GovernanceRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<GovernanceRoleDefinition>(nameof(RoleDefinition)); }
            set { BackingStore?.Set(nameof(RoleDefinition), value); }
        }
        /// <summary>Required. The id of the role definition that the role setting is associated with.</summary>
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>(nameof(RoleDefinitionId)); }
            set { BackingStore?.Set(nameof(RoleDefinitionId), value); }
        }
        /// <summary>The rule settings that are evaluated when a user tries to add an eligible role assignment. The setting is not supported for now.</summary>
        public List<GovernanceRuleSetting> UserEligibleSettings {
            get { return BackingStore?.Get<List<GovernanceRuleSetting>>(nameof(UserEligibleSettings)); }
            set { BackingStore?.Set(nameof(UserEligibleSettings), value); }
        }
        /// <summary>The rule settings that are evaluated when a user tries to activate his role assignment.</summary>
        public List<GovernanceRuleSetting> UserMemberSettings {
            get { return BackingStore?.Get<List<GovernanceRuleSetting>>(nameof(UserMemberSettings)); }
            set { BackingStore?.Set(nameof(UserMemberSettings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GovernanceRoleSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRoleSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"adminEligibleSettings", n => { AdminEligibleSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"adminMemberSettings", n => { AdminMemberSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"lastUpdatedBy", n => { LastUpdatedBy = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"userEligibleSettings", n => { UserEligibleSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"userMemberSettings", n => { UserMemberSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<GovernanceRuleSetting>("adminEligibleSettings", AdminEligibleSettings);
            writer.WriteCollectionOfObjectValues<GovernanceRuleSetting>("adminMemberSettings", AdminMemberSettings);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("lastUpdatedBy", LastUpdatedBy);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteCollectionOfObjectValues<GovernanceRuleSetting>("userEligibleSettings", UserEligibleSettings);
            writer.WriteCollectionOfObjectValues<GovernanceRuleSetting>("userMemberSettings", UserMemberSettings);
        }
    }
}
