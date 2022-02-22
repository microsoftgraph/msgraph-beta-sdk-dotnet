using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class CredentialUserRegistrationsSummary : Entity, IParsable {
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The number of users that are capable of performing multi-factor authentication or self service password reset. Optional. Read-only.</summary>
        public int? MfaAndSsprCapableUserCount { get; set; }
        /// <summary>The state of a conditional access policy that enforces multi-factor authentication. Optional. Read-only.</summary>
        public string MfaConditionalAccessPolicyState { get; set; }
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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastRefreshedDateTime", (o,n) => { (o as CredentialUserRegistrationsSummary).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"mfaAndSsprCapableUserCount", (o,n) => { (o as CredentialUserRegistrationsSummary).MfaAndSsprCapableUserCount = n.GetIntValue(); } },
                {"mfaConditionalAccessPolicyState", (o,n) => { (o as CredentialUserRegistrationsSummary).MfaConditionalAccessPolicyState = n.GetStringValue(); } },
                {"mfaRegisteredUserCount", (o,n) => { (o as CredentialUserRegistrationsSummary).MfaRegisteredUserCount = n.GetIntValue(); } },
                {"securityDefaultsEnabled", (o,n) => { (o as CredentialUserRegistrationsSummary).SecurityDefaultsEnabled = n.GetBoolValue(); } },
                {"ssprEnabledUserCount", (o,n) => { (o as CredentialUserRegistrationsSummary).SsprEnabledUserCount = n.GetIntValue(); } },
                {"ssprRegisteredUserCount", (o,n) => { (o as CredentialUserRegistrationsSummary).SsprRegisteredUserCount = n.GetIntValue(); } },
                {"tenantDisplayName", (o,n) => { (o as CredentialUserRegistrationsSummary).TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as CredentialUserRegistrationsSummary).TenantId = n.GetStringValue(); } },
                {"totalUserCount", (o,n) => { (o as CredentialUserRegistrationsSummary).TotalUserCount = n.GetIntValue(); } },
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
