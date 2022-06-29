using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class WindowsProtectionState : Entity, IParsable {
        /// <summary>The anti-malware version for the managed device. Optional. Read-only.</summary>
        public string AntiMalwareVersion {
            get { return BackingStore?.Get<string>(nameof(AntiMalwareVersion)); }
            set { BackingStore?.Set(nameof(AntiMalwareVersion), value); }
        }
        /// <summary>A flag indicating whether attention is required for the managed device. Optional. Read-only.</summary>
        public bool? AttentionRequired {
            get { return BackingStore?.Get<bool?>(nameof(AttentionRequired)); }
            set { BackingStore?.Set(nameof(AttentionRequired), value); }
        }
        /// <summary>A flag indicating whether the managed device has been deleted. Optional. Read-only.</summary>
        public bool? DeviceDeleted {
            get { return BackingStore?.Get<bool?>(nameof(DeviceDeleted)); }
            set { BackingStore?.Set(nameof(DeviceDeleted), value); }
        }
        /// <summary>The date and time the device property has been refreshed. Optional. Read-only.</summary>
        public DateTimeOffset? DevicePropertyRefreshDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DevicePropertyRefreshDateTime)); }
            set { BackingStore?.Set(nameof(DevicePropertyRefreshDateTime), value); }
        }
        /// <summary>The anti-virus engine version for the managed device. Optional. Read-only.</summary>
        public string EngineVersion {
            get { return BackingStore?.Get<string>(nameof(EngineVersion)); }
            set { BackingStore?.Set(nameof(EngineVersion), value); }
        }
        /// <summary>A flag indicating whether quick scan is overdue for the managed device. Optional. Read-only.</summary>
        public bool? FullScanOverdue {
            get { return BackingStore?.Get<bool?>(nameof(FullScanOverdue)); }
            set { BackingStore?.Set(nameof(FullScanOverdue), value); }
        }
        /// <summary>A flag indicating whether full scan is overdue for the managed device. Optional. Read-only.</summary>
        public bool? FullScanRequired {
            get { return BackingStore?.Get<bool?>(nameof(FullScanRequired)); }
            set { BackingStore?.Set(nameof(FullScanRequired), value); }
        }
        /// <summary>The date and time a full scan was completed. Optional. Read-only.</summary>
        public DateTimeOffset? LastFullScanDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastFullScanDateTime)); }
            set { BackingStore?.Set(nameof(LastFullScanDateTime), value); }
        }
        /// <summary>The version anti-malware version used to perform the last full scan. Optional. Read-only.</summary>
        public string LastFullScanSignatureVersion {
            get { return BackingStore?.Get<string>(nameof(LastFullScanSignatureVersion)); }
            set { BackingStore?.Set(nameof(LastFullScanSignatureVersion), value); }
        }
        /// <summary>The date and time a quick scan was completed. Optional. Read-only.</summary>
        public DateTimeOffset? LastQuickScanDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastQuickScanDateTime)); }
            set { BackingStore?.Set(nameof(LastQuickScanDateTime), value); }
        }
        /// <summary>The version anti-malware version used to perform the last full scan. Optional. Read-only.</summary>
        public string LastQuickScanSignatureVersion {
            get { return BackingStore?.Get<string>(nameof(LastQuickScanSignatureVersion)); }
            set { BackingStore?.Set(nameof(LastQuickScanSignatureVersion), value); }
        }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastRefreshedDateTime)); }
            set { BackingStore?.Set(nameof(LastRefreshedDateTime), value); }
        }
        /// <summary>The date and time the protection state was last reported for the managed device. Optional. Read-only.</summary>
        public DateTimeOffset? LastReportedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastReportedDateTime)); }
            set { BackingStore?.Set(nameof(LastReportedDateTime), value); }
        }
        /// <summary>A flag indicating whether malware protection is enabled for the managed device. Optional. Read-only.</summary>
        public bool? MalwareProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MalwareProtectionEnabled)); }
            set { BackingStore?.Set(nameof(MalwareProtectionEnabled), value); }
        }
        /// <summary>The health state for the managed device. Optional. Read-only.</summary>
        public string ManagedDeviceHealthState {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceHealthState)); }
            set { BackingStore?.Set(nameof(ManagedDeviceHealthState), value); }
        }
        /// <summary>The unique identifier for the managed device. Optional. Read-only.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>The display name for the managed device. Optional. Read-only.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceName), value); }
        }
        /// <summary>A flag indicating whether the network inspection system is enabled. Optional. Read-only.</summary>
        public bool? NetworkInspectionSystemEnabled {
            get { return BackingStore?.Get<bool?>(nameof(NetworkInspectionSystemEnabled)); }
            set { BackingStore?.Set(nameof(NetworkInspectionSystemEnabled), value); }
        }
        /// <summary>A flag indicating weather a quick scan is overdue. Optional. Read-only.</summary>
        public bool? QuickScanOverdue {
            get { return BackingStore?.Get<bool?>(nameof(QuickScanOverdue)); }
            set { BackingStore?.Set(nameof(QuickScanOverdue), value); }
        }
        /// <summary>A flag indicating whether real time protection is enabled. Optional. Read-only.</summary>
        public bool? RealTimeProtectionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(RealTimeProtectionEnabled)); }
            set { BackingStore?.Set(nameof(RealTimeProtectionEnabled), value); }
        }
        /// <summary>A flag indicating whether a reboot is required. Optional. Read-only.</summary>
        public bool? RebootRequired {
            get { return BackingStore?.Get<bool?>(nameof(RebootRequired)); }
            set { BackingStore?.Set(nameof(RebootRequired), value); }
        }
        /// <summary>A flag indicating whether an signature update is overdue. Optional. Read-only.</summary>
        public bool? SignatureUpdateOverdue {
            get { return BackingStore?.Get<bool?>(nameof(SignatureUpdateOverdue)); }
            set { BackingStore?.Set(nameof(SignatureUpdateOverdue), value); }
        }
        /// <summary>The signature version for the managed device. Optional. Read-only.</summary>
        public string SignatureVersion {
            get { return BackingStore?.Get<string>(nameof(SignatureVersion)); }
            set { BackingStore?.Set(nameof(SignatureVersion), value); }
        }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>(nameof(TenantDisplayName)); }
            set { BackingStore?.Set(nameof(TenantDisplayName), value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsProtectionState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsProtectionState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"antiMalwareVersion", n => { AntiMalwareVersion = n.GetStringValue(); } },
                {"attentionRequired", n => { AttentionRequired = n.GetBoolValue(); } },
                {"deviceDeleted", n => { DeviceDeleted = n.GetBoolValue(); } },
                {"devicePropertyRefreshDateTime", n => { DevicePropertyRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                {"engineVersion", n => { EngineVersion = n.GetStringValue(); } },
                {"fullScanOverdue", n => { FullScanOverdue = n.GetBoolValue(); } },
                {"fullScanRequired", n => { FullScanRequired = n.GetBoolValue(); } },
                {"lastFullScanDateTime", n => { LastFullScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastFullScanSignatureVersion", n => { LastFullScanSignatureVersion = n.GetStringValue(); } },
                {"lastQuickScanDateTime", n => { LastQuickScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastQuickScanSignatureVersion", n => { LastQuickScanSignatureVersion = n.GetStringValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                {"malwareProtectionEnabled", n => { MalwareProtectionEnabled = n.GetBoolValue(); } },
                {"managedDeviceHealthState", n => { ManagedDeviceHealthState = n.GetStringValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"networkInspectionSystemEnabled", n => { NetworkInspectionSystemEnabled = n.GetBoolValue(); } },
                {"quickScanOverdue", n => { QuickScanOverdue = n.GetBoolValue(); } },
                {"realTimeProtectionEnabled", n => { RealTimeProtectionEnabled = n.GetBoolValue(); } },
                {"rebootRequired", n => { RebootRequired = n.GetBoolValue(); } },
                {"signatureUpdateOverdue", n => { SignatureUpdateOverdue = n.GetBoolValue(); } },
                {"signatureVersion", n => { SignatureVersion = n.GetStringValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("antiMalwareVersion", AntiMalwareVersion);
            writer.WriteBoolValue("attentionRequired", AttentionRequired);
            writer.WriteBoolValue("deviceDeleted", DeviceDeleted);
            writer.WriteDateTimeOffsetValue("devicePropertyRefreshDateTime", DevicePropertyRefreshDateTime);
            writer.WriteStringValue("engineVersion", EngineVersion);
            writer.WriteBoolValue("fullScanOverdue", FullScanOverdue);
            writer.WriteBoolValue("fullScanRequired", FullScanRequired);
            writer.WriteDateTimeOffsetValue("lastFullScanDateTime", LastFullScanDateTime);
            writer.WriteStringValue("lastFullScanSignatureVersion", LastFullScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastQuickScanDateTime", LastQuickScanDateTime);
            writer.WriteStringValue("lastQuickScanSignatureVersion", LastQuickScanSignatureVersion);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteBoolValue("malwareProtectionEnabled", MalwareProtectionEnabled);
            writer.WriteStringValue("managedDeviceHealthState", ManagedDeviceHealthState);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteBoolValue("networkInspectionSystemEnabled", NetworkInspectionSystemEnabled);
            writer.WriteBoolValue("quickScanOverdue", QuickScanOverdue);
            writer.WriteBoolValue("realTimeProtectionEnabled", RealTimeProtectionEnabled);
            writer.WriteBoolValue("rebootRequired", RebootRequired);
            writer.WriteBoolValue("signatureUpdateOverdue", SignatureUpdateOverdue);
            writer.WriteStringValue("signatureVersion", SignatureVersion);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
