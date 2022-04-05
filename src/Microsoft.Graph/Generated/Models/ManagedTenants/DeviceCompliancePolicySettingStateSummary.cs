using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class DeviceCompliancePolicySettingStateSummary : Entity, IParsable {
        /// <summary>The number of devices in a conflict state. Optional. Read-only.</summary>
        public int? ConflictDeviceCount { get; set; }
        /// <summary>The number of devices in an error state. Optional. Read-only.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>The number of devices in a failed state. Optional. Read-only.</summary>
        public int? FailedDeviceCount { get; set; }
        /// <summary>The identifer for the Microsoft Intune account. Required. Read-only.</summary>
        public string IntuneAccountId { get; set; }
        /// <summary>The identifier for the Intune setting. Optional. Read-only.</summary>
        public string IntuneSettingId { get; set; }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The number of devices in a not applicable state. Optional. Read-only.</summary>
        public int? NotApplicableDeviceCount { get; set; }
        /// <summary>The number of devices in a pending state. Optional. Read-only.</summary>
        public int? PendingDeviceCount { get; set; }
        /// <summary>The type for the device compliance policy. Optional. Read-only.</summary>
        public string PolicyType { get; set; }
        /// <summary>The name for the setting within the device compliance policy. Optional. Read-only.</summary>
        public string SettingName { get; set; }
        /// <summary>The number of devices in a succeeded state. Optional. Read-only.</summary>
        public int? SucceededDeviceCount { get; set; }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceCompliancePolicySettingStateSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCompliancePolicySettingStateSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conflictDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).ErrorDeviceCount = n.GetIntValue(); } },
                {"failedDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).FailedDeviceCount = n.GetIntValue(); } },
                {"intuneAccountId", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).IntuneAccountId = n.GetStringValue(); } },
                {"intuneSettingId", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).IntuneSettingId = n.GetStringValue(); } },
                {"lastRefreshedDateTime", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"notApplicableDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).NotApplicableDeviceCount = n.GetIntValue(); } },
                {"pendingDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).PendingDeviceCount = n.GetIntValue(); } },
                {"policyType", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).PolicyType = n.GetStringValue(); } },
                {"settingName", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).SettingName = n.GetStringValue(); } },
                {"succeededDeviceCount", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).SucceededDeviceCount = n.GetIntValue(); } },
                {"tenantDisplayName", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as DeviceCompliancePolicySettingStateSummary).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteStringValue("intuneAccountId", IntuneAccountId);
            writer.WriteStringValue("intuneSettingId", IntuneSettingId);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("pendingDeviceCount", PendingDeviceCount);
            writer.WriteStringValue("policyType", PolicyType);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("succeededDeviceCount", SucceededDeviceCount);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
