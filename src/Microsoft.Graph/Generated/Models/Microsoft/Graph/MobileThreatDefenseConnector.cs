using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MobileThreatDefenseConnector : Entity, IParsable {
        /// <summary>For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about installed applications from Intune</summary>
        public bool? AllowPartnerToCollectIOSApplicationMetadata { get; set; }
        /// <summary>For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about personally installed applications from Intune</summary>
        public bool? AllowPartnerToCollectIOSPersonalApplicationMetadata { get; set; }
        /// <summary>For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? AndroidDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For Android, set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? AndroidEnabled { get; set; }
        /// <summary>For Android, set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.</summary>
        public bool? AndroidMobileApplicationManagementEnabled { get; set; }
        /// <summary>For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? IosDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For IOS, get or set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? IosEnabled { get; set; }
        /// <summary>For IOS, get or set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.</summary>
        public bool? IosMobileApplicationManagementEnabled { get; set; }
        /// <summary>DateTime of last Heartbeat recieved from the Data Sync Partner</summary>
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
        /// <summary>For Mac, get or set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? MacDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For Mac, get or set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? MacEnabled { get; set; }
        /// <summary>When TRUE, configuration profile management via Microsoft Defender for Endpoint is enabled. When FALSE, configuration profile management via Microsoft Defender for Endpoint is disabled.</summary>
        public bool? MicrosoftDefenderForEndpointAttachEnabled { get; set; }
        /// <summary>Data Sync Partner state for this account. Possible values are: unavailable, available, enabled, unresponsive.</summary>
        public MobileThreatPartnerTenantState? PartnerState { get; set; }
        /// <summary>Get or Set days the per tenant tolerance to unresponsiveness for this partner integration</summary>
        public int? PartnerUnresponsivenessThresholdInDays { get; set; }
        /// <summary>Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner</summary>
        public bool? PartnerUnsupportedOsVersionBlocked { get; set; }
        /// <summary>For Windows, set whether Intune must receive data from the data sync partner prior to marking a device compliant</summary>
        public bool? WindowsDeviceBlockedOnMissingPartnerData { get; set; }
        /// <summary>For Windows, get or set whether data from the data sync partner should be used during compliance evaluations</summary>
        public bool? WindowsEnabled { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"allowPartnerToCollectIOSApplicationMetadata", (o,n) => { (o as MobileThreatDefenseConnector).AllowPartnerToCollectIOSApplicationMetadata = n.GetBoolValue(); } },
                {"allowPartnerToCollectIOSPersonalApplicationMetadata", (o,n) => { (o as MobileThreatDefenseConnector).AllowPartnerToCollectIOSPersonalApplicationMetadata = n.GetBoolValue(); } },
                {"androidDeviceBlockedOnMissingPartnerData", (o,n) => { (o as MobileThreatDefenseConnector).AndroidDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"androidEnabled", (o,n) => { (o as MobileThreatDefenseConnector).AndroidEnabled = n.GetBoolValue(); } },
                {"androidMobileApplicationManagementEnabled", (o,n) => { (o as MobileThreatDefenseConnector).AndroidMobileApplicationManagementEnabled = n.GetBoolValue(); } },
                {"iosDeviceBlockedOnMissingPartnerData", (o,n) => { (o as MobileThreatDefenseConnector).IosDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"iosEnabled", (o,n) => { (o as MobileThreatDefenseConnector).IosEnabled = n.GetBoolValue(); } },
                {"iosMobileApplicationManagementEnabled", (o,n) => { (o as MobileThreatDefenseConnector).IosMobileApplicationManagementEnabled = n.GetBoolValue(); } },
                {"lastHeartbeatDateTime", (o,n) => { (o as MobileThreatDefenseConnector).LastHeartbeatDateTime = n.GetDateTimeOffsetValue(); } },
                {"macDeviceBlockedOnMissingPartnerData", (o,n) => { (o as MobileThreatDefenseConnector).MacDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"macEnabled", (o,n) => { (o as MobileThreatDefenseConnector).MacEnabled = n.GetBoolValue(); } },
                {"microsoftDefenderForEndpointAttachEnabled", (o,n) => { (o as MobileThreatDefenseConnector).MicrosoftDefenderForEndpointAttachEnabled = n.GetBoolValue(); } },
                {"partnerState", (o,n) => { (o as MobileThreatDefenseConnector).PartnerState = n.GetEnumValue<MobileThreatPartnerTenantState>(); } },
                {"partnerUnresponsivenessThresholdInDays", (o,n) => { (o as MobileThreatDefenseConnector).PartnerUnresponsivenessThresholdInDays = n.GetIntValue(); } },
                {"partnerUnsupportedOsVersionBlocked", (o,n) => { (o as MobileThreatDefenseConnector).PartnerUnsupportedOsVersionBlocked = n.GetBoolValue(); } },
                {"windowsDeviceBlockedOnMissingPartnerData", (o,n) => { (o as MobileThreatDefenseConnector).WindowsDeviceBlockedOnMissingPartnerData = n.GetBoolValue(); } },
                {"windowsEnabled", (o,n) => { (o as MobileThreatDefenseConnector).WindowsEnabled = n.GetBoolValue(); } },
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
