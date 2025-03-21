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
    /// KioskModeApp v4 for Win32 app support
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WindowsKioskWin32App : global::Microsoft.Graph.Beta.Models.WindowsKioskAppBase, IParsable
    {
        /// <summary>This is the classicapppath to be used by v4 Win32 app while in Kiosk Mode</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClassicAppPath
        {
            get { return BackingStore?.Get<string?>("classicAppPath"); }
            set { BackingStore?.Set("classicAppPath", value); }
        }
#nullable restore
#else
        public string ClassicAppPath
        {
            get { return BackingStore?.Get<string>("classicAppPath"); }
            set { BackingStore?.Set("classicAppPath", value); }
        }
#endif
        /// <summary>Edge kiosk (url) for Edge kiosk mode</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EdgeKiosk
        {
            get { return BackingStore?.Get<string?>("edgeKiosk"); }
            set { BackingStore?.Set("edgeKiosk", value); }
        }
#nullable restore
#else
        public string EdgeKiosk
        {
            get { return BackingStore?.Get<string>("edgeKiosk"); }
            set { BackingStore?.Set("edgeKiosk", value); }
        }
#endif
        /// <summary>Edge kiosk idle timeout in minutes for Edge kiosk mode. Valid values 0 to 1440</summary>
        public int? EdgeKioskIdleTimeoutMinutes
        {
            get { return BackingStore?.Get<int?>("edgeKioskIdleTimeoutMinutes"); }
            set { BackingStore?.Set("edgeKioskIdleTimeoutMinutes", value); }
        }
        /// <summary>Edge kiosk type</summary>
        public global::Microsoft.Graph.Beta.Models.WindowsEdgeKioskType? EdgeKioskType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsEdgeKioskType?>("edgeKioskType"); }
            set { BackingStore?.Set("edgeKioskType", value); }
        }
        /// <summary>Edge first run flag for Edge kiosk mode</summary>
        public bool? EdgeNoFirstRun
        {
            get { return BackingStore?.Get<bool?>("edgeNoFirstRun"); }
            set { BackingStore?.Set("edgeNoFirstRun", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.WindowsKioskWin32App"/> and sets the default values.
        /// </summary>
        public WindowsKioskWin32App() : base()
        {
            OdataType = "#microsoft.graph.windowsKioskWin32App";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsKioskWin32App"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsKioskWin32App CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsKioskWin32App();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "classicAppPath", n => { ClassicAppPath = n.GetStringValue(); } },
                { "edgeKiosk", n => { EdgeKiosk = n.GetStringValue(); } },
                { "edgeKioskIdleTimeoutMinutes", n => { EdgeKioskIdleTimeoutMinutes = n.GetIntValue(); } },
                { "edgeKioskType", n => { EdgeKioskType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.WindowsEdgeKioskType>(); } },
                { "edgeNoFirstRun", n => { EdgeNoFirstRun = n.GetBoolValue(); } },
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
            writer.WriteStringValue("classicAppPath", ClassicAppPath);
            writer.WriteStringValue("edgeKiosk", EdgeKiosk);
            writer.WriteIntValue("edgeKioskIdleTimeoutMinutes", EdgeKioskIdleTimeoutMinutes);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.WindowsEdgeKioskType>("edgeKioskType", EdgeKioskType);
            writer.WriteBoolValue("edgeNoFirstRun", EdgeNoFirstRun);
        }
    }
}
#pragma warning restore CS0618
