using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of governanceResource entities.</summary>
    public class GovernanceRoleSetting : Entity, IParsable {
        /// <summary>The rule settings that are evaluated when an administrator tries to add an eligible role assignment.</summary>
        public List<GovernanceRuleSetting> AdminEligibleSettings { get; set; }
        /// <summary>The rule settings that are evaluated when an administrator tries to add a direct member role assignment.</summary>
        public List<GovernanceRuleSetting> AdminMemberSettings { get; set; }
        /// <summary>Read-only. Indicate if the roleSetting is a default roleSetting</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Read-only. The display name of the administrator who last updated the roleSetting.</summary>
        public string LastUpdatedBy { get; set; }
        /// <summary>Read-only. The time when the role setting was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>Read-only. The associated resource for this role setting.</summary>
        public GovernanceResource Resource { get; set; }
        /// <summary>Required. The id of the resource that the role setting is associated with.</summary>
        public string ResourceId { get; set; }
        /// <summary>Read-only. The role definition that is enforced with this role setting.</summary>
        public GovernanceRoleDefinition RoleDefinition { get; set; }
        /// <summary>Required. The id of the role definition that the role setting is associated with.</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>The rule settings that are evaluated when a user tries to add an eligible role assignment. The setting is not supported for now.</summary>
        public List<GovernanceRuleSetting> UserEligibleSettings { get; set; }
        /// <summary>The rule settings that are evaluated when a user tries to activate his role assignment.</summary>
        public List<GovernanceRuleSetting> UserMemberSettings { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"adminEligibleSettings", (o,n) => { (o as GovernanceRoleSetting).AdminEligibleSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"adminMemberSettings", (o,n) => { (o as GovernanceRoleSetting).AdminMemberSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"isDefault", (o,n) => { (o as GovernanceRoleSetting).IsDefault = n.GetBoolValue(); } },
                {"lastUpdatedBy", (o,n) => { (o as GovernanceRoleSetting).LastUpdatedBy = n.GetStringValue(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as GovernanceRoleSetting).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", (o,n) => { (o as GovernanceRoleSetting).Resource = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                {"resourceId", (o,n) => { (o as GovernanceRoleSetting).ResourceId = n.GetStringValue(); } },
                {"roleDefinition", (o,n) => { (o as GovernanceRoleSetting).RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", (o,n) => { (o as GovernanceRoleSetting).RoleDefinitionId = n.GetStringValue(); } },
                {"userEligibleSettings", (o,n) => { (o as GovernanceRoleSetting).UserEligibleSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"userMemberSettings", (o,n) => { (o as GovernanceRoleSetting).UserMemberSettings = n.GetCollectionOfObjectValues<GovernanceRuleSetting>(GovernanceRuleSetting.CreateFromDiscriminatorValue).ToList(); } },
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
