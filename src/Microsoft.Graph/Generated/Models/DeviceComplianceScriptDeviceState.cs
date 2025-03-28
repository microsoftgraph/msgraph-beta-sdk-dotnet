// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties for device run state of the device compliance script.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceComplianceScriptDeviceState : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public global::Microsoft.Graph.Beta.Models.RunState? DetectionState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RunState?>("detectionState"); }
            set { BackingStore?.Set("detectionState", value); }
        }
        /// <summary>The next timestamp of when the device compliance script is expected to execute</summary>
        public DateTimeOffset? ExpectedStateUpdateDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expectedStateUpdateDateTime"); }
            set { BackingStore?.Set("expectedStateUpdateDateTime", value); }
        }
        /// <summary>The last timestamp of when the device compliance script executed</summary>
        public DateTimeOffset? LastStateUpdateDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastStateUpdateDateTime"); }
            set { BackingStore?.Set("lastStateUpdateDateTime", value); }
        }
        /// <summary>The last time that Intune Managment Extension synced with Intune</summary>
        public DateTimeOffset? LastSyncDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The managed device on which the device compliance script executed</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ManagedDevice? ManagedDevice
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedDevice?>("managedDevice"); }
            set { BackingStore?.Set("managedDevice", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ManagedDevice ManagedDevice
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice"); }
            set { BackingStore?.Set("managedDevice", value); }
        }
#endif
        /// <summary>Error from the detection script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScriptError
        {
            get { return BackingStore?.Get<string?>("scriptError"); }
            set { BackingStore?.Set("scriptError", value); }
        }
#nullable restore
#else
        public string ScriptError
        {
            get { return BackingStore?.Get<string>("scriptError"); }
            set { BackingStore?.Set("scriptError", value); }
        }
#endif
        /// <summary>Output of the detection script</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScriptOutput
        {
            get { return BackingStore?.Get<string?>("scriptOutput"); }
            set { BackingStore?.Set("scriptOutput", value); }
        }
#nullable restore
#else
        public string ScriptOutput
        {
            get { return BackingStore?.Get<string>("scriptOutput"); }
            set { BackingStore?.Set("scriptOutput", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceComplianceScriptDeviceState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceComplianceScriptDeviceState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceComplianceScriptDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "detectionState", n => { DetectionState = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.RunState>(); } },
                { "expectedStateUpdateDateTime", n => { ExpectedStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastStateUpdateDateTime", n => { LastStateUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "managedDevice", n => { ManagedDevice = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ManagedDevice>(global::Microsoft.Graph.Beta.Models.ManagedDevice.CreateFromDiscriminatorValue); } },
                { "scriptError", n => { ScriptError = n.GetStringValue(); } },
                { "scriptOutput", n => { ScriptOutput = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.RunState>("detectionState", DetectionState);
            writer.WriteDateTimeOffsetValue("expectedStateUpdateDateTime", ExpectedStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastStateUpdateDateTime", LastStateUpdateDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ManagedDevice>("managedDevice", ManagedDevice);
            writer.WriteStringValue("scriptError", ScriptError);
            writer.WriteStringValue("scriptOutput", ScriptOutput);
        }
    }
}
#pragma warning restore CS0618
