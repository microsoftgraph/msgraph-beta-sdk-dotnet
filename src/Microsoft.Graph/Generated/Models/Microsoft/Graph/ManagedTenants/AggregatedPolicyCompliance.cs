using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class AggregatedPolicyCompliance : Entity, IParsable {
        /// <summary>Identifier for the device compliance policy. Optional. Read-only.</summary>
        public string CompliancePolicyId { get; set; }
        /// <summary>Name of the device compliance policy. Optional. Read-only.</summary>
        public string CompliancePolicyName { get; set; }
        /// <summary>Platform for the device compliance policy. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, androidAOSP, all. Optional. Read-only.</summary>
        public string CompliancePolicyPlatform { get; set; }
        /// <summary>The type of compliance policy. Optional. Read-only.</summary>
        public string CompliancePolicyType { get; set; }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The number of devices that are in a compliant status. Optional. Read-only.</summary>
        public long? NumberOfCompliantDevices { get; set; }
        /// <summary>The number of devices that are in an error status. Optional. Read-only.</summary>
        public long? NumberOfErrorDevices { get; set; }
        /// <summary>The number of device that are in a non-compliant status. Optional. Read-only.</summary>
        public long? NumberOfNonCompliantDevices { get; set; }
        /// <summary>The date and time the device policy was last modified. Optional. Read-only.</summary>
        public DateTimeOffset? PolicyModifiedDateTime { get; set; }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AggregatedPolicyCompliance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AggregatedPolicyCompliance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"compliancePolicyId", (o,n) => { (o as AggregatedPolicyCompliance).CompliancePolicyId = n.GetStringValue(); } },
                {"compliancePolicyName", (o,n) => { (o as AggregatedPolicyCompliance).CompliancePolicyName = n.GetStringValue(); } },
                {"compliancePolicyPlatform", (o,n) => { (o as AggregatedPolicyCompliance).CompliancePolicyPlatform = n.GetStringValue(); } },
                {"compliancePolicyType", (o,n) => { (o as AggregatedPolicyCompliance).CompliancePolicyType = n.GetStringValue(); } },
                {"lastRefreshedDateTime", (o,n) => { (o as AggregatedPolicyCompliance).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"numberOfCompliantDevices", (o,n) => { (o as AggregatedPolicyCompliance).NumberOfCompliantDevices = n.GetLongValue(); } },
                {"numberOfErrorDevices", (o,n) => { (o as AggregatedPolicyCompliance).NumberOfErrorDevices = n.GetLongValue(); } },
                {"numberOfNonCompliantDevices", (o,n) => { (o as AggregatedPolicyCompliance).NumberOfNonCompliantDevices = n.GetLongValue(); } },
                {"policyModifiedDateTime", (o,n) => { (o as AggregatedPolicyCompliance).PolicyModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantDisplayName", (o,n) => { (o as AggregatedPolicyCompliance).TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as AggregatedPolicyCompliance).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("compliancePolicyId", CompliancePolicyId);
            writer.WriteStringValue("compliancePolicyName", CompliancePolicyName);
            writer.WriteStringValue("compliancePolicyPlatform", CompliancePolicyPlatform);
            writer.WriteStringValue("compliancePolicyType", CompliancePolicyType);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteLongValue("numberOfCompliantDevices", NumberOfCompliantDevices);
            writer.WriteLongValue("numberOfErrorDevices", NumberOfErrorDevices);
            writer.WriteLongValue("numberOfNonCompliantDevices", NumberOfNonCompliantDevices);
            writer.WriteDateTimeOffsetValue("policyModifiedDateTime", PolicyModifiedDateTime);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
