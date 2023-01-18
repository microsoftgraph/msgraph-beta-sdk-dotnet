using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties for device run state of the device compliance script.
    /// </summary>
    public class DeviceComplianceScriptDeviceState : Entity, IParsable {
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public RunState? DetectionState {
            get { return BackingStore?.Get<RunState?>("detectionState"); }
            set { BackingStore?.Set("detectionState", value); }
        }
        /// <summary>The next timestamp of when the device compliance script is expected to execute</summary>
        public DateTimeOffset? ExpectedStateUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expectedStateUpdateDateTime"); }
            set { BackingStore?.Set("expectedStateUpdateDateTime", value); }
        }
        /// <summary>The last timestamp of when the device compliance script executed</summary>
        public DateTimeOffset? LastStateUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastStateUpdateDateTime"); }
            set { BackingStore?.Set("lastStateUpdateDateTime", value); }
        }
        /// <summary>The last time that Intune Managment Extension synced with Intune</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The managed device on which the device compliance script executed</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.ManagedDevice? ManagedDevice {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDevice?>("managedDevice"); }
            set { BackingStore?.Set("managedDevice", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.ManagedDevice ManagedDevice {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice"); }
            set { BackingStore?.Set("managedDevice", value); }
        }
#endif
        /// <summary>Error from the detection script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ScriptError {
            get { return BackingStore?.Get<string?>("scriptError"); }
            set { BackingStore?.Set("scriptError", value); }
        }
#else
        public string ScriptError {
            get { return BackingStore?.Get<string>("scriptError"); }
            set { BackingStore?.Set("scriptError", value); }
        }
#endif
        /// <summary>Output of the detection script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ScriptOutput {
            get { return BackingStore?.Get<string?>("scriptOutput"); }
            set { BackingStore?.Set("scriptOutput", value); }
        }
#else
        public string ScriptOutput {
            get { return BackingStore?.Get<string>("scriptOutput"); }
            set { BackingStore?.Set("scriptOutput", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceComplianceScriptDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"detectionState", n => { DetectionState = n.GetEnumValue<RunState>(); } },
                {"expectedStateUpdateDateTime", n => { ExpectedStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastStateUpdateDateTime", n => { LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDevice", n => { ManagedDevice = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>(Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue); } },
                {"scriptError", n => { ScriptError = n.GetStringValue(); } },
                {"scriptOutput", n => { ScriptOutput = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<RunState>("detectionState", DetectionState);
            writer.WriteDateTimeOffsetValue("expectedStateUpdateDateTime", ExpectedStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice", ManagedDevice);
            writer.WriteStringValue("scriptError", ScriptError);
            writer.WriteStringValue("scriptOutput", ScriptOutput);
        }
    }
}
