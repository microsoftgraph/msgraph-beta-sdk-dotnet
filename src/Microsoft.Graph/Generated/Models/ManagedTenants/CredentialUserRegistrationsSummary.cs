using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class CredentialUserRegistrationsSummary : Entity, IParsable {
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The number of users that are capable of performing multi-factor authentication or self service password reset. Optional. Read-only.</summary>
        public int? MfaAndSsprCapableUserCount { get; set; }
        /// <summary>The state of a conditional access policy that enforces multi-factor authentication. Optional. Read-only.</summary>
        public string MfaConditionalAccessPolicyState { get; set; }
        /// <summary>The mfaExcludedUserCount property</summary>
        public int? MfaExcludedUserCount { get; set; }
        /// <summary>The number of users registered for multi-factor authentication. Optional. Read-only.</summary>
        public int? MfaRegisteredUserCount { get; set; }
        /// <summary>A flag indicating whether Identity Security Defaults is enabled. Optional. Read-only.</summary>
        public bool? SecurityDefaultsEnabled { get; set; }
        /// <summary>The number of users enabled for self service password reset. Optional. Read-only.</summary>
        public int? SsprEnabledUserCount { get; set; }
        /// <summary>The number of users registered for self service password reset. Optional. Read-only.</summary>
        public int? SsprRegisteredUserCount { get; set; }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>The total number of users in the given managed tenant. Optional. Read-only.</summary>
        public int? TotalUserCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CredentialUserRegistrationsSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CredentialUserRegistrationsSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"mfaAndSsprCapableUserCount", n => { MfaAndSsprCapableUserCount = n.GetIntValue(); } },
                {"mfaConditionalAccessPolicyState", n => { MfaConditionalAccessPolicyState = n.GetStringValue(); } },
                {"mfaExcludedUserCount", n => { MfaExcludedUserCount = n.GetIntValue(); } },
                {"mfaRegisteredUserCount", n => { MfaRegisteredUserCount = n.GetIntValue(); } },
                {"securityDefaultsEnabled", n => { SecurityDefaultsEnabled = n.GetBoolValue(); } },
                {"ssprEnabledUserCount", n => { SsprEnabledUserCount = n.GetIntValue(); } },
                {"ssprRegisteredUserCount", n => { SsprRegisteredUserCount = n.GetIntValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"totalUserCount", n => { TotalUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteIntValue("mfaAndSsprCapableUserCount", MfaAndSsprCapableUserCount);
            writer.WriteStringValue("mfaConditionalAccessPolicyState", MfaConditionalAccessPolicyState);
            writer.WriteIntValue("mfaExcludedUserCount", MfaExcludedUserCount);
            writer.WriteIntValue("mfaRegisteredUserCount", MfaRegisteredUserCount);
            writer.WriteBoolValue("securityDefaultsEnabled", SecurityDefaultsEnabled);
            writer.WriteIntValue("ssprEnabledUserCount", SsprEnabledUserCount);
            writer.WriteIntValue("ssprRegisteredUserCount", SsprRegisteredUserCount);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("totalUserCount", TotalUserCount);
        }
    }
}
