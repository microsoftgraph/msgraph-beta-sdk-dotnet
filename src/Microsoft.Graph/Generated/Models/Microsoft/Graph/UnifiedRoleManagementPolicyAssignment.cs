using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UnifiedRoleManagementPolicyAssignment : Entity, IParsable {
        /// <summary>The policy for the assignment.</summary>
        public UnifiedRoleManagementPolicy Policy { get; set; }
        /// <summary>The id of the policy.</summary>
        public string PolicyId { get; set; }
        /// <summary>The id of the role definition where the policy applies. If not specified, the policy applies to all roles.</summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>The id of the scope where the policy is assigned. E.g. '/', groupId, etc.</summary>
        public string ScopeId { get; set; }
        /// <summary>The type of the scope where the policy is assigned. One of Directory, DirectoryRole, Group.</summary>
        public string ScopeType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"policy", (o,n) => { (o as UnifiedRoleManagementPolicyAssignment).Policy = n.GetObjectValue<UnifiedRoleManagementPolicy>(); } },
                {"policyId", (o,n) => { (o as UnifiedRoleManagementPolicyAssignment).PolicyId = n.GetStringValue(); } },
                {"roleDefinitionId", (o,n) => { (o as UnifiedRoleManagementPolicyAssignment).RoleDefinitionId = n.GetStringValue(); } },
                {"scopeId", (o,n) => { (o as UnifiedRoleManagementPolicyAssignment).ScopeId = n.GetStringValue(); } },
                {"scopeType", (o,n) => { (o as UnifiedRoleManagementPolicyAssignment).ScopeType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UnifiedRoleManagementPolicy>("policy", Policy);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteStringValue("scopeId", ScopeId);
            writer.WriteStringValue("scopeType", ScopeType);
        }
    }
}
