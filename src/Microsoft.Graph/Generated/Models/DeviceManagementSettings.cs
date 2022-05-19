using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The property to determine if Android device administrator enrollment is enabled for this account.</summary>
        public bool? AndroidDeviceAdministratorEnrollmentEnabled {
            get { return BackingStore?.Get<bool?>(nameof(AndroidDeviceAdministratorEnrollmentEnabled)); }
            set { BackingStore?.Set(nameof(AndroidDeviceAdministratorEnrollmentEnabled), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Derived Credential Provider to use for this account. Possible values are: notConfigured, entrustDataCard, purebred, xTec, intercede.</summary>
        public DerivedCredentialProviderType? DerivedCredentialProvider {
            get { return BackingStore?.Get<DerivedCredentialProviderType?>(nameof(DerivedCredentialProvider)); }
            set { BackingStore?.Set(nameof(DerivedCredentialProvider), value); }
        }
        /// <summary>The Derived Credential Provider self-service URI.</summary>
        public string DerivedCredentialUrl {
            get { return BackingStore?.Get<string>(nameof(DerivedCredentialUrl)); }
            set { BackingStore?.Set(nameof(DerivedCredentialUrl), value); }
        }
        /// <summary>The number of days a device is allowed to go without checking in to remain compliant.</summary>
        public int? DeviceComplianceCheckinThresholdDays {
            get { return BackingStore?.Get<int?>(nameof(DeviceComplianceCheckinThresholdDays)); }
            set { BackingStore?.Set(nameof(DeviceComplianceCheckinThresholdDays), value); }
        }
        /// <summary>When the device does not check in for specified number of days, the company data might be removed and the device will not be under management. Valid values 30 to 270</summary>
        public int? DeviceInactivityBeforeRetirementInDay {
            get { return BackingStore?.Get<int?>(nameof(DeviceInactivityBeforeRetirementInDay)); }
            set { BackingStore?.Set(nameof(DeviceInactivityBeforeRetirementInDay), value); }
        }
        /// <summary>Determines whether the autopilot diagnostic feature is enabled or not.</summary>
        public bool? EnableAutopilotDiagnostics {
            get { return BackingStore?.Get<bool?>(nameof(EnableAutopilotDiagnostics)); }
            set { BackingStore?.Set(nameof(EnableAutopilotDiagnostics), value); }
        }
        /// <summary>Determines whether the device group membership report feature is enabled or not.</summary>
        public bool? EnableDeviceGroupMembershipReport {
            get { return BackingStore?.Get<bool?>(nameof(EnableDeviceGroupMembershipReport)); }
            set { BackingStore?.Set(nameof(EnableDeviceGroupMembershipReport), value); }
        }
        /// <summary>Determines whether the enhanced troubleshooting UX is enabled or not.</summary>
        public bool? EnableEnhancedTroubleshootingExperience {
            get { return BackingStore?.Get<bool?>(nameof(EnableEnhancedTroubleshootingExperience)); }
            set { BackingStore?.Set(nameof(EnableEnhancedTroubleshootingExperience), value); }
        }
        /// <summary>Determines whether the log collection feature should be available for use.</summary>
        public bool? EnableLogCollection {
            get { return BackingStore?.Get<bool?>(nameof(EnableLogCollection)); }
            set { BackingStore?.Set(nameof(EnableLogCollection), value); }
        }
        /// <summary>Is feature enabled or not for enhanced jailbreak detection.</summary>
        public bool? EnhancedJailBreak {
            get { return BackingStore?.Get<bool?>(nameof(EnhancedJailBreak)); }
            set { BackingStore?.Set(nameof(EnhancedJailBreak), value); }
        }
        /// <summary>The property to determine whether to ignore unsupported compliance settings on certian models of devices.</summary>
        public bool? IgnoreDevicesForUnsupportedSettingsEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IgnoreDevicesForUnsupportedSettingsEnabled)); }
            set { BackingStore?.Set(nameof(IgnoreDevicesForUnsupportedSettingsEnabled), value); }
        }
        /// <summary>Is feature enabled or not for scheduled action for rule.</summary>
        public bool? IsScheduledActionEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsScheduledActionEnabled)); }
            set { BackingStore?.Set(nameof(IsScheduledActionEnabled), value); }
        }
        /// <summary>Device should be noncompliant when there is no compliance policy targeted when this is true</summary>
        public bool? SecureByDefault {
            get { return BackingStore?.Get<bool?>(nameof(SecureByDefault)); }
            set { BackingStore?.Set(nameof(SecureByDefault), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementSettings and sets the default values.
        /// </summary>
        public DeviceManagementSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"androidDeviceAdministratorEnrollmentEnabled", n => { AndroidDeviceAdministratorEnrollmentEnabled = n.GetBoolValue(); } },
                {"derivedCredentialProvider", n => { DerivedCredentialProvider = n.GetEnumValue<DerivedCredentialProviderType>(); } },
                {"derivedCredentialUrl", n => { DerivedCredentialUrl = n.GetStringValue(); } },
                {"deviceComplianceCheckinThresholdDays", n => { DeviceComplianceCheckinThresholdDays = n.GetIntValue(); } },
                {"deviceInactivityBeforeRetirementInDay", n => { DeviceInactivityBeforeRetirementInDay = n.GetIntValue(); } },
                {"enableAutopilotDiagnostics", n => { EnableAutopilotDiagnostics = n.GetBoolValue(); } },
                {"enableDeviceGroupMembershipReport", n => { EnableDeviceGroupMembershipReport = n.GetBoolValue(); } },
                {"enableEnhancedTroubleshootingExperience", n => { EnableEnhancedTroubleshootingExperience = n.GetBoolValue(); } },
                {"enableLogCollection", n => { EnableLogCollection = n.GetBoolValue(); } },
                {"enhancedJailBreak", n => { EnhancedJailBreak = n.GetBoolValue(); } },
                {"ignoreDevicesForUnsupportedSettingsEnabled", n => { IgnoreDevicesForUnsupportedSettingsEnabled = n.GetBoolValue(); } },
                {"isScheduledActionEnabled", n => { IsScheduledActionEnabled = n.GetBoolValue(); } },
                {"secureByDefault", n => { SecureByDefault = n.GetBoolValue(); } },
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
