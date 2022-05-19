using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Compilance Policy Setting State summary across the account.</summary>
    public class DeviceCompliancePolicySettingStateSummary : Entity, IParsable {
        /// <summary>Number of compliant devices</summary>
        public int? CompliantDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(CompliantDeviceCount)); }
            set { BackingStore?.Set(nameof(CompliantDeviceCount), value); }
        }
        /// <summary>Number of conflict devices</summary>
        public int? ConflictDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ConflictDeviceCount)); }
            set { BackingStore?.Set(nameof(ConflictDeviceCount), value); }
        }
        /// <summary>Not yet documented</summary>
        public List<DeviceComplianceSettingState> DeviceComplianceSettingStates {
            get { return BackingStore?.Get<List<DeviceComplianceSettingState>>(nameof(DeviceComplianceSettingStates)); }
            set { BackingStore?.Set(nameof(DeviceComplianceSettingStates), value); }
        }
        /// <summary>Number of error devices</summary>
        public int? ErrorDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorDeviceCount)); }
            set { BackingStore?.Set(nameof(ErrorDeviceCount), value); }
        }
        /// <summary>Number of NonCompliant devices</summary>
        public int? NonCompliantDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(NonCompliantDeviceCount)); }
            set { BackingStore?.Set(nameof(NonCompliantDeviceCount), value); }
        }
        /// <summary>Number of not applicable devices</summary>
        public int? NotApplicableDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(NotApplicableDeviceCount)); }
            set { BackingStore?.Set(nameof(NotApplicableDeviceCount), value); }
        }
        /// <summary>Setting platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, androidAOSP, all.</summary>
        public PolicyPlatformType? PlatformType {
            get { return BackingStore?.Get<PolicyPlatformType?>(nameof(PlatformType)); }
            set { BackingStore?.Set(nameof(PlatformType), value); }
        }
        /// <summary>Number of remediated devices</summary>
        public int? RemediatedDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(RemediatedDeviceCount)); }
            set { BackingStore?.Set(nameof(RemediatedDeviceCount), value); }
        }
        /// <summary>The setting class name and property name.</summary>
        public string Setting {
            get { return BackingStore?.Get<string>(nameof(Setting)); }
            set { BackingStore?.Set(nameof(Setting), value); }
        }
        /// <summary>Name of the setting.</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>(nameof(SettingName)); }
            set { BackingStore?.Set(nameof(SettingName), value); }
        }
        /// <summary>Number of unknown devices</summary>
        public int? UnknownDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(UnknownDeviceCount)); }
            set { BackingStore?.Set(nameof(UnknownDeviceCount), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                {"deviceComplianceSettingStates", n => { DeviceComplianceSettingStates = n.GetCollectionOfObjectValues<DeviceComplianceSettingState>(DeviceComplianceSettingState.CreateFromDiscriminatorValue).ToList(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<PolicyPlatformType>(); } },
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
                {"setting", n => { Setting = n.GetStringValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("conflictDeviceCount", ConflictDeviceCount);
            writer.WriteCollectionOfObjectValues<DeviceComplianceSettingState>("deviceComplianceSettingStates", DeviceComplianceSettingStates);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteEnumValue<PolicyPlatformType>("platformType", PlatformType);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
