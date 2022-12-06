using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class AggregatedPolicyCompliance : Entity, IParsable {
        /// <summary>Identifier for the device compliance policy. Optional. Read-only.</summary>
        public string CompliancePolicyId {
            get { return BackingStore?.Get<string>("compliancePolicyId"); }
            set { BackingStore?.Set("compliancePolicyId", value); }
        }
        /// <summary>Name of the device compliance policy. Optional. Read-only.</summary>
        public string CompliancePolicyName {
            get { return BackingStore?.Get<string>("compliancePolicyName"); }
            set { BackingStore?.Set("compliancePolicyName", value); }
        }
        /// <summary>Platform for the device compliance policy. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, androidAOSP, all. Optional. Read-only.</summary>
        public string CompliancePolicyPlatform {
            get { return BackingStore?.Get<string>("compliancePolicyPlatform"); }
            set { BackingStore?.Set("compliancePolicyPlatform", value); }
        }
        /// <summary>The type of compliance policy. Optional. Read-only.</summary>
        public string CompliancePolicyType {
            get { return BackingStore?.Get<string>("compliancePolicyType"); }
            set { BackingStore?.Set("compliancePolicyType", value); }
        }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>The number of devices that are in a compliant status. Optional. Read-only.</summary>
        public long? NumberOfCompliantDevices {
            get { return BackingStore?.Get<long?>("numberOfCompliantDevices"); }
            set { BackingStore?.Set("numberOfCompliantDevices", value); }
        }
        /// <summary>The number of devices that are in an error status. Optional. Read-only.</summary>
        public long? NumberOfErrorDevices {
            get { return BackingStore?.Get<long?>("numberOfErrorDevices"); }
            set { BackingStore?.Set("numberOfErrorDevices", value); }
        }
        /// <summary>The number of device that are in a non-compliant status. Optional. Read-only.</summary>
        public long? NumberOfNonCompliantDevices {
            get { return BackingStore?.Get<long?>("numberOfNonCompliantDevices"); }
            set { BackingStore?.Set("numberOfNonCompliantDevices", value); }
        }
        /// <summary>The date and time the device policy was last modified. Optional. Read-only.</summary>
        public DateTimeOffset? PolicyModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("policyModifiedDateTime"); }
            set { BackingStore?.Set("policyModifiedDateTime", value); }
        }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AggregatedPolicyCompliance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AggregatedPolicyCompliance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliancePolicyId", n => { CompliancePolicyId = n.GetStringValue(); } },
                {"compliancePolicyName", n => { CompliancePolicyName = n.GetStringValue(); } },
                {"compliancePolicyPlatform", n => { CompliancePolicyPlatform = n.GetStringValue(); } },
                {"compliancePolicyType", n => { CompliancePolicyType = n.GetStringValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"numberOfCompliantDevices", n => { NumberOfCompliantDevices = n.GetLongValue(); } },
                {"numberOfErrorDevices", n => { NumberOfErrorDevices = n.GetLongValue(); } },
                {"numberOfNonCompliantDevices", n => { NumberOfNonCompliantDevices = n.GetLongValue(); } },
                {"policyModifiedDateTime", n => { PolicyModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
