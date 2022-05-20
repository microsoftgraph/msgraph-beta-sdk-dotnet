using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Compilance Policy and Configuration for a Setting State summary</summary>
    public class SettingStateDeviceSummary : Entity, IParsable {
        /// <summary>Device Compliant count for the setting</summary>
        public int? CompliantDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(CompliantDeviceCount)); }
            set { BackingStore?.Set(nameof(CompliantDeviceCount), value); }
        }
        /// <summary>Device conflict error count for the setting</summary>
        public int? ConflictDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ConflictDeviceCount)); }
            set { BackingStore?.Set(nameof(ConflictDeviceCount), value); }
        }
        /// <summary>Device error count for the setting</summary>
        public int? ErrorDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorDeviceCount)); }
            set { BackingStore?.Set(nameof(ErrorDeviceCount), value); }
        }
        /// <summary>Name of the InstancePath for the setting</summary>
        public string InstancePath {
            get { return BackingStore?.Get<string>(nameof(InstancePath)); }
            set { BackingStore?.Set(nameof(InstancePath), value); }
        }
        /// <summary>Device NonCompliant count for the setting</summary>
        public int? NonCompliantDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(NonCompliantDeviceCount)); }
            set { BackingStore?.Set(nameof(NonCompliantDeviceCount), value); }
        }
        /// <summary>Device Not Applicable count for the setting</summary>
        public int? NotApplicableDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(NotApplicableDeviceCount)); }
            set { BackingStore?.Set(nameof(NotApplicableDeviceCount), value); }
        }
        /// <summary>Device Compliant count for the setting</summary>
        public int? RemediatedDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(RemediatedDeviceCount)); }
            set { BackingStore?.Set(nameof(RemediatedDeviceCount), value); }
        }
        /// <summary>Name of the setting</summary>
        public string SettingName {
            get { return BackingStore?.Get<string>(nameof(SettingName)); }
            set { BackingStore?.Set(nameof(SettingName), value); }
        }
        /// <summary>Device Unkown count for the setting</summary>
        public int? UnknownDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(UnknownDeviceCount)); }
            set { BackingStore?.Set(nameof(UnknownDeviceCount), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SettingStateDeviceSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SettingStateDeviceSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"conflictDeviceCount", n => { ConflictDeviceCount = n.GetIntValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"instancePath", n => { InstancePath = n.GetStringValue(); } },
                {"nonCompliantDeviceCount", n => { NonCompliantDeviceCount = n.GetIntValue(); } },
                {"notApplicableDeviceCount", n => { NotApplicableDeviceCount = n.GetIntValue(); } },
                {"remediatedDeviceCount", n => { RemediatedDeviceCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteStringValue("instancePath", InstancePath);
            writer.WriteIntValue("nonCompliantDeviceCount", NonCompliantDeviceCount);
            writer.WriteIntValue("notApplicableDeviceCount", NotApplicableDeviceCount);
            writer.WriteIntValue("remediatedDeviceCount", RemediatedDeviceCount);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
