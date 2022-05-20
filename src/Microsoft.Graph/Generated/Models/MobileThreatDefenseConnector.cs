using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Entity which represents a connection to Mobile threat defense partner.</summary>
    public class MobileThreatDefenseConnector : Entity, IParsable {
        /// <summary>For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about installed applications from Intune</summary>
        public bool? AllowPartnerToCollectIOSApplicationMetadata {
            get { return BackingStore?.Get<bool?>(nameof(AllowPartnerToCollectIOSApplicationMetadata)); }
            set { BackingStore?.Set(nameof(AllowPartnerToCollectIOSApplicationMetadata), value); }
        }
        /// <summary>For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about personally installed applications from Intune</summary>
        public bool? AllowPartnerToCollectIOSPersonalApplicationMetadata {
            get { return BackingStore?.Get<bool?>(nameof(AllowPartnerToCollectIOSPersonalApplicationMetadata)); }
            set { BackingStore?.Set(nameof(AllowPartnerToCollectIOSPersonalApplicationMetadata), value); }
        }
        /// <summary>For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? AndroidDeviceBlockedOnMissingPartnerData {
            get { return BackingStore?.Get<bool?>(nameof(AndroidDeviceBlockedOnMissingPartnerData)); }
            set { BackingStore?.Set(nameof(AndroidDeviceBlockedOnMissingPartnerData), value); }
        }
        /// <summary>For Android, set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? AndroidEnabled {
            get { return BackingStore?.Get<bool?>(nameof(AndroidEnabled)); }
            set { BackingStore?.Set(nameof(AndroidEnabled), value); }
        }
        /// <summary>For Android, set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.</summary>
        public bool? AndroidMobileApplicationManagementEnabled {
            get { return BackingStore?.Get<bool?>(nameof(AndroidMobileApplicationManagementEnabled)); }
            set { BackingStore?.Set(nameof(AndroidMobileApplicationManagementEnabled), value); }
        }
        /// <summary>For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? IosDeviceBlockedOnMissingPartnerData {
            get { return BackingStore?.Get<bool?>(nameof(IosDeviceBlockedOnMissingPartnerData)); }
            set { BackingStore?.Set(nameof(IosDeviceBlockedOnMissingPartnerData), value); }
        }
        /// <summary>For IOS, get or set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? IosEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IosEnabled)); }
            set { BackingStore?.Set(nameof(IosEnabled), value); }
        }
        /// <summary>For IOS, get or set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.</summary>
        public bool? IosMobileApplicationManagementEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IosMobileApplicationManagementEnabled)); }
            set { BackingStore?.Set(nameof(IosMobileApplicationManagementEnabled), value); }
        }
        /// <summary>DateTime of last Heartbeat recieved from the Data Sync Partner</summary>
        public DateTimeOffset? LastHeartbeatDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastHeartbeatDateTime)); }
            set { BackingStore?.Set(nameof(LastHeartbeatDateTime), value); }
        }
        /// <summary>For Mac, get or set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? MacDeviceBlockedOnMissingPartnerData {
            get { return BackingStore?.Get<bool?>(nameof(MacDeviceBlockedOnMissingPartnerData)); }
            set { BackingStore?.Set(nameof(MacDeviceBlockedOnMissingPartnerData), value); }
        }
        /// <summary>For Mac, get or set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? MacEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MacEnabled)); }
            set { BackingStore?.Set(nameof(MacEnabled), value); }
        }
        /// <summary>When TRUE, configuration profile management via Microsoft Defender for Endpoint is enabled. When FALSE, configuration profile management via Microsoft Defender for Endpoint is disabled.</summary>
        public bool? MicrosoftDefenderForEndpointAttachEnabled {
            get { return BackingStore?.Get<bool?>(nameof(MicrosoftDefenderForEndpointAttachEnabled)); }
            set { BackingStore?.Set(nameof(MicrosoftDefenderForEndpointAttachEnabled), value); }
        }
        /// <summary>Data Sync Partner state for this account. Possible values are: unavailable, available, enabled, unresponsive.</summary>
        public MobileThreatPartnerTenantState? PartnerState {
            get { return BackingStore?.Get<MobileThreatPartnerTenantState?>(nameof(PartnerState)); }
            set { BackingStore?.Set(nameof(PartnerState), value); }
        }
        /// <summary>Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</summary>
        public int? PartnerUnresponsivenessThresholdInDays {
            get { return BackingStore?.Get<int?>(nameof(PartnerUnresponsivenessThresholdInDays)); }
            set { BackingStore?.Set(nameof(PartnerUnresponsivenessThresholdInDays), value); }
        }
        /// <summary>Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner</summary>
        public bool? PartnerUnsupportedOsVersionBlocked {
            get { return BackingStore?.Get<bool?>(nameof(PartnerUnsupportedOsVersionBlocked)); }
            set { BackingStore?.Set(nameof(PartnerUnsupportedOsVersionBlocked), value); }
        }
        /// <summary>For Windows, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? WindowsDeviceBlockedOnMissingPartnerData {
            get { return BackingStore?.Get<bool?>(nameof(WindowsDeviceBlockedOnMissingPartnerData)); }
            set { BackingStore?.Set(nameof(WindowsDeviceBlockedOnMissingPartnerData), value); }
        }
        /// <summary>For Windows, get or set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? WindowsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(WindowsEnabled)); }
            set { BackingStore?.Set(nameof(WindowsEnabled), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileThreatDefenseConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileThreatDefenseConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowPartnerToCollectIOSApplicationMetadata", n => { AllowPartnerToCollectIOSApplicationMetadata = n.GetBoolValue(); } },
                {"allowPartnerToCollectIOSPersonalApplicationMetadata", n => { AllowPartnerToCollectIOSPersonalApplicationMetadata = n.GetBoolValue(); } },
                {"androidDeviceBlockedOnMissingPartnerData", n => { AndroidDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"androidEnabled", n => { AndroidEnabled = n.GetBoolValue(); } },
                {"androidMobileApplicationManagementEnabled", n => { AndroidMobileApplicationManagementEnabled = n.GetBoolValue(); } },
                {"iosDeviceBlockedOnMissingPartnerData", n => { IosDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"iosEnabled", n => { IosEnabled = n.GetBoolValue(); } },
                {"iosMobileApplicationManagementEnabled", n => { IosMobileApplicationManagementEnabled = n.GetBoolValue(); } },
                {"lastHeartbeatDateTime", n => { LastHeartbeatDateTime = n.GetDateTimeOffsetValue(); } },
                {"macDeviceBlockedOnMissingPartnerData", n => { MacDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"macEnabled", n => { MacEnabled = n.GetBoolValue(); } },
                {"microsoftDefenderForEndpointAttachEnabled", n => { MicrosoftDefenderForEndpointAttachEnabled = n.GetBoolValue(); } },
                {"partnerState", n => { PartnerState = n.GetEnumValue<MobileThreatPartnerTenantState>(); } },
                {"partnerUnresponsivenessThresholdInDays", n => { PartnerUnresponsivenessThresholdInDays = n.GetIntValue(); } },
                {"partnerUnsupportedOsVersionBlocked", n => { PartnerUnsupportedOsVersionBlocked = n.GetBoolValue(); } },
                {"windowsDeviceBlockedOnMissingPartnerData", n => { WindowsDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"windowsEnabled", n => { WindowsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowPartnerToCollectIOSApplicationMetadata", AllowPartnerToCollectIOSApplicationMetadata);
            writer.WriteBoolValue("allowPartnerToCollectIOSPersonalApplicationMetadata", AllowPartnerToCollectIOSPersonalApplicationMetadata);
            writer.WriteBoolValue("androidDeviceBlockedOnMissingPartnerData", AndroidDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("androidEnabled", AndroidEnabled);
            writer.WriteBoolValue("androidMobileApplicationManagementEnabled", AndroidMobileApplicationManagementEnabled);
            writer.WriteBoolValue("iosDeviceBlockedOnMissingPartnerData", IosDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("iosEnabled", IosEnabled);
            writer.WriteBoolValue("iosMobileApplicationManagementEnabled", IosMobileApplicationManagementEnabled);
            writer.WriteDateTimeOffsetValue("lastHeartbeatDateTime", LastHeartbeatDateTime);
            writer.WriteBoolValue("macDeviceBlockedOnMissingPartnerData", MacDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("macEnabled", MacEnabled);
            writer.WriteBoolValue("microsoftDefenderForEndpointAttachEnabled", MicrosoftDefenderForEndpointAttachEnabled);
            writer.WriteEnumValue<MobileThreatPartnerTenantState>("partnerState", PartnerState);
            writer.WriteIntValue("partnerUnresponsivenessThresholdInDays", PartnerUnresponsivenessThresholdInDays);
            writer.WriteBoolValue("partnerUnsupportedOsVersionBlocked", PartnerUnsupportedOsVersionBlocked);
            writer.WriteBoolValue("windowsDeviceBlockedOnMissingPartnerData", WindowsDeviceBlockedOnMissingPartnerData);
            writer.WriteBoolValue("windowsEnabled", WindowsEnabled);
        }
    }
}
