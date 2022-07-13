using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Win32LobAppRegistryDetection : Win32LobAppDetection, IParsable {
        /// <summary>A value indicating whether this registry path is for checking 32-bit app on 64-bit system</summary>
        public bool? Check32BitOn64System {
            get { return BackingStore?.Get<bool?>("check32BitOn64System"); }
            set { BackingStore?.Set("check32BitOn64System", value); }
        }
        /// <summary>Contains all supported registry data detection type.</summary>
        public Win32LobAppRegistryDetectionType? DetectionType {
            get { return BackingStore?.Get<Win32LobAppRegistryDetectionType?>("detectionType"); }
            set { BackingStore?.Set("detectionType", value); }
        }
        /// <summary>The registry detection value</summary>
        public string DetectionValue {
            get { return BackingStore?.Get<string>("detectionValue"); }
            set { BackingStore?.Set("detectionValue", value); }
        }
        /// <summary>The registry key path to detect Win32 Line of Business (LoB) app</summary>
        public string KeyPath {
            get { return BackingStore?.Get<string>("keyPath"); }
            set { BackingStore?.Set("keyPath", value); }
        }
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppDetectionOperator? Operator {
            get { return BackingStore?.Get<Win32LobAppDetectionOperator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>The registry value name</summary>
        public string ValueName {
            get { return BackingStore?.Get<string>("valueName"); }
            set { BackingStore?.Set("valueName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Win32LobAppRegistryDetection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppRegistryDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"check32BitOn64System", n => { Check32BitOn64System = n.GetBoolValue(); } },
                {"detectionType", n => { DetectionType = n.GetEnumValue<Win32LobAppRegistryDetectionType>(); } },
                {"detectionValue", n => { DetectionValue = n.GetStringValue(); } },
                {"keyPath", n => { KeyPath = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<Win32LobAppDetectionOperator>(); } },
                {"valueName", n => { ValueName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("check32BitOn64System", Check32BitOn64System);
            writer.WriteEnumValue<Win32LobAppRegistryDetectionType>("detectionType", DetectionType);
            writer.WriteStringValue("detectionValue", DetectionValue);
            writer.WriteStringValue("keyPath", KeyPath);
            writer.WriteEnumValue<Win32LobAppDetectionOperator>("operator", Operator);
            writer.WriteStringValue("valueName", ValueName);
        }
    }
}
