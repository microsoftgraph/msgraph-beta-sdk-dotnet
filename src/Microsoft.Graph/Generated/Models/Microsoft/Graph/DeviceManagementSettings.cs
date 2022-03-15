using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceManagementSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The property to determine if Android device administrator enrollment is enabled for this account.</summary>
        public bool? AndroidDeviceAdministratorEnrollmentEnabled { get; set; }
        /// <summary>The Derived Credential Provider to use for this account. Possible values are: notConfigured, entrustDataCard, purebred, xTec, intercede.</summary>
        public DerivedCredentialProviderType? DerivedCredentialProvider { get; set; }
        /// <summary>The Derived Credential Provider self-service URI.</summary>
        public string DerivedCredentialUrl { get; set; }
        /// <summary>The number of days a device is allowed to go without checking in to remain compliant.</summary>
        public int? DeviceComplianceCheckinThresholdDays { get; set; }
        /// <summary>When the device does not check in for specified number of days, the company data might be removed and the device will not be under management. Valid values 30 to 270</summary>
        public int? DeviceInactivityBeforeRetirementInDay { get; set; }
        /// <summary>Determines whether the autopilot diagnostic feature is enabled or not.</summary>
        public bool? EnableAutopilotDiagnostics { get; set; }
        /// <summary>Determines whether the device group membership report feature is enabled or not.</summary>
        public bool? EnableDeviceGroupMembershipReport { get; set; }
        /// <summary>Determines whether the enhanced troubleshooting UX is enabled or not.</summary>
        public bool? EnableEnhancedTroubleshootingExperience { get; set; }
        /// <summary>Determines whether the log collection feature should be available for use.</summary>
        public bool? EnableLogCollection { get; set; }
        /// <summary>Is feature enabled or not for enhanced jailbreak detection.</summary>
        public bool? EnhancedJailBreak { get; set; }
        /// <summary>The property to determine whether to ignore unsupported compliance settings on certian models of devices.</summary>
        public bool? IgnoreDevicesForUnsupportedSettingsEnabled { get; set; }
        /// <summary>Is feature enabled or not for scheduled action for rule.</summary>
        public bool? IsScheduledActionEnabled { get; set; }
        /// <summary>Device should be noncompliant when there is no compliance policy targeted when this is true</summary>
        public bool? SecureByDefault { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementSettings and sets the default values.
        /// </summary>
        public DeviceManagementSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"androidDeviceAdministratorEnrollmentEnabled", (o,n) => { (o as DeviceManagementSettings).AndroidDeviceAdministratorEnrollmentEnabled = n.GetBoolValue(); } },
                {"derivedCredentialProvider", (o,n) => { (o as DeviceManagementSettings).DerivedCredentialProvider = n.GetEnumValue<DerivedCredentialProviderType>(); } },
                {"derivedCredentialUrl", (o,n) => { (o as DeviceManagementSettings).DerivedCredentialUrl = n.GetStringValue(); } },
                {"deviceComplianceCheckinThresholdDays", (o,n) => { (o as DeviceManagementSettings).DeviceComplianceCheckinThresholdDays = n.GetIntValue(); } },
                {"deviceInactivityBeforeRetirementInDay", (o,n) => { (o as DeviceManagementSettings).DeviceInactivityBeforeRetirementInDay = n.GetIntValue(); } },
                {"enableAutopilotDiagnostics", (o,n) => { (o as DeviceManagementSettings).EnableAutopilotDiagnostics = n.GetBoolValue(); } },
                {"enableDeviceGroupMembershipReport", (o,n) => { (o as DeviceManagementSettings).EnableDeviceGroupMembershipReport = n.GetBoolValue(); } },
                {"enableEnhancedTroubleshootingExperience", (o,n) => { (o as DeviceManagementSettings).EnableEnhancedTroubleshootingExperience = n.GetBoolValue(); } },
                {"enableLogCollection", (o,n) => { (o as DeviceManagementSettings).EnableLogCollection = n.GetBoolValue(); } },
                {"enhancedJailBreak", (o,n) => { (o as DeviceManagementSettings).EnhancedJailBreak = n.GetBoolValue(); } },
                {"ignoreDevicesForUnsupportedSettingsEnabled", (o,n) => { (o as DeviceManagementSettings).IgnoreDevicesForUnsupportedSettingsEnabled = n.GetBoolValue(); } },
                {"isScheduledActionEnabled", (o,n) => { (o as DeviceManagementSettings).IsScheduledActionEnabled = n.GetBoolValue(); } },
                {"secureByDefault", (o,n) => { (o as DeviceManagementSettings).SecureByDefault = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("androidDeviceAdministratorEnrollmentEnabled", AndroidDeviceAdministratorEnrollmentEnabled);
            writer.WriteEnumValue<DerivedCredentialProviderType>("derivedCredentialProvider", DerivedCredentialProvider);
            writer.WriteStringValue("derivedCredentialUrl", DerivedCredentialUrl);
            writer.WriteIntValue("deviceComplianceCheckinThresholdDays", DeviceComplianceCheckinThresholdDays);
            writer.WriteIntValue("deviceInactivityBeforeRetirementInDay", DeviceInactivityBeforeRetirementInDay);
            writer.WriteBoolValue("enableAutopilotDiagnostics", EnableAutopilotDiagnostics);
            writer.WriteBoolValue("enableDeviceGroupMembershipReport", EnableDeviceGroupMembershipReport);
            writer.WriteBoolValue("enableEnhancedTroubleshootingExperience", EnableEnhancedTroubleshootingExperience);
            writer.WriteBoolValue("enableLogCollection", EnableLogCollection);
            writer.WriteBoolValue("enhancedJailBreak", EnhancedJailBreak);
            writer.WriteBoolValue("ignoreDevicesForUnsupportedSettingsEnabled", IgnoreDevicesForUnsupportedSettingsEnabled);
            writer.WriteBoolValue("isScheduledActionEnabled", IsScheduledActionEnabled);
            writer.WriteBoolValue("secureByDefault", SecureByDefault);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
