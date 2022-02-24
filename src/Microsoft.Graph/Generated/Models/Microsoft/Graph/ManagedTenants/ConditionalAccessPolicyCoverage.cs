using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ConditionalAccessPolicyCoverage : Entity, IParsable {
        /// <summary>The state for the conditional access policy. Possible values are: enabled, disabled, enabledForReportingButNotEnforced. Required. Read-only.</summary>
        public string ConditionalAccessPolicyState { get; set; }
        /// <summary>The date and time the conditional access policy was last modified. Required. Read-only.</summary>
        public DateTimeOffset? LatestPolicyModifiedDateTime { get; set; }
        /// <summary>A flag indicating whether the conditional access policy requires device compliance. Required. Read-only.</summary>
        public bool? RequiresDeviceCompliance { get; set; }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conditionalAccessPolicyState", (o,n) => { (o as ConditionalAccessPolicyCoverage).ConditionalAccessPolicyState = n.GetStringValue(); } },
                {"latestPolicyModifiedDateTime", (o,n) => { (o as ConditionalAccessPolicyCoverage).LatestPolicyModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requiresDeviceCompliance", (o,n) => { (o as ConditionalAccessPolicyCoverage).RequiresDeviceCompliance = n.GetBoolValue(); } },
                {"tenantDisplayName", (o,n) => { (o as ConditionalAccessPolicyCoverage).TenantDisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("conditionalAccessPolicyState", ConditionalAccessPolicyState);
            writer.WriteDateTimeOffsetValue("latestPolicyModifiedDateTime", LatestPolicyModifiedDateTime);
            writer.WriteBoolValue("requiresDeviceCompliance", RequiresDeviceCompliance);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
        }
    }
}
