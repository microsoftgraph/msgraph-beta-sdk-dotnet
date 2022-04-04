using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UnifiedRoleManagementPolicy : Entity, IParsable {
        /// <summary>Description for the policy.</summary>
        public string Description { get; set; }
        /// <summary>Display name for the policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Not implemented. The list of effective rules like approval rules and expiration rules evaluated based on inherited referenced rules. For example, if there is a tenant-wide policy to enforce enabling an approval rule, the effective rule will be to enable approval even if the policy has a rule to disable approval.</summary>
        public List<UnifiedRoleManagementPolicyRule> EffectiveRules { get; set; }
        /// <summary>This can only be set to true for a single tenant wide policy which will apply to all scopes and roles. Set the scopeId to &apos;/&apos; and scopeType to Directory.</summary>
        public bool? IsOrganizationDefault { get; set; }
        /// <summary>The identity who last modified the role setting.</summary>
        public Identity LastModifiedBy { get; set; }
        /// <summary>The time when the role setting was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The collection of rules like approval rules and expiration rules.</summary>
        public List<UnifiedRoleManagementPolicyRule> Rules { get; set; }
        /// <summary>The id of the scope where the policy is created. Can be / for the tenant or a group ID. Required.</summary>
        public string ScopeId { get; set; }
        /// <summary>The type of the scope where the policy is created. One of Directory, DirectoryRole. Required.</summary>
        public string ScopeType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRoleManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as UnifiedRoleManagementPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as UnifiedRoleManagementPolicy).DisplayName = n.GetStringValue(); } },
                {"effectiveRules", (o,n) => { (o as UnifiedRoleManagementPolicy).EffectiveRules = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>(UnifiedRoleManagementPolicyRule.CreateFromDiscriminatorValue).ToList(); } },
                {"isOrganizationDefault", (o,n) => { (o as UnifiedRoleManagementPolicy).IsOrganizationDefault = n.GetBoolValue(); } },
                {"lastModifiedBy", (o,n) => { (o as UnifiedRoleManagementPolicy).LastModifiedBy = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as UnifiedRoleManagementPolicy).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"rules", (o,n) => { (o as UnifiedRoleManagementPolicy).Rules = n.GetCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>(UnifiedRoleManagementPolicyRule.CreateFromDiscriminatorValue).ToList(); } },
                {"scopeId", (o,n) => { (o as UnifiedRoleManagementPolicy).ScopeId = n.GetStringValue(); } },
                {"scopeType", (o,n) => { (o as UnifiedRoleManagementPolicy).ScopeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>("effectiveRules", EffectiveRules);
            writer.WriteBoolValue("isOrganizationDefault", IsOrganizationDefault);
            writer.WriteObjectValue<Identity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementPolicyRule>("rules", Rules);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
