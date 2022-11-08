using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsKioskWin32App : WindowsKioskAppBase, IParsable {
        /// <summary>This is the classicapppath to be used by v4 Win32 app while in Kiosk Mode</summary>
        public string ClassicAppPath {
            get { return BackingStore?.Get<string>("classicAppPath"); }
            set { BackingStore?.Set("classicAppPath", value); }
        }
        /// <summary>Edge kiosk (url) for Edge kiosk mode</summary>
        public string EdgeKiosk {
            get { return BackingStore?.Get<string>("edgeKiosk"); }
            set { BackingStore?.Set("edgeKiosk", value); }
        }
        /// <summary>Edge kiosk idle timeout in minutes for Edge kiosk mode. Valid values 0 to 1440</summary>
        public int? EdgeKioskIdleTimeoutMinutes {
            get { return BackingStore?.Get<int?>("edgeKioskIdleTimeoutMinutes"); }
            set { BackingStore?.Set("edgeKioskIdleTimeoutMinutes", value); }
        }
        /// <summary>Edge kiosk type</summary>
        public WindowsEdgeKioskType? EdgeKioskType {
            get { return BackingStore?.Get<WindowsEdgeKioskType?>("edgeKioskType"); }
            set { BackingStore?.Set("edgeKioskType", value); }
        }
        /// <summary>Edge first run flag for Edge kiosk mode</summary>
        public bool? EdgeNoFirstRun {
            get { return BackingStore?.Get<bool?>("edgeNoFirstRun"); }
            set { BackingStore?.Set("edgeNoFirstRun", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsKioskWin32App and sets the default values.
        /// </summary>
        public WindowsKioskWin32App() : base() {
            OdataType = "#microsoft.graph.windowsKioskWin32App";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsKioskWin32App CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskWin32App();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classicAppPath", n => { ClassicAppPath = n.GetStringValue(); } },
                {"edgeKiosk", n => { EdgeKiosk = n.GetStringValue(); } },
                {"edgeKioskIdleTimeoutMinutes", n => { EdgeKioskIdleTimeoutMinutes = n.GetIntValue(); } },
                {"edgeKioskType", n => { EdgeKioskType = n.GetEnumValue<WindowsEdgeKioskType>(); } },
                {"edgeNoFirstRun", n => { EdgeNoFirstRun = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("classicAppPath", ClassicAppPath);
            writer.WriteStringValue("edgeKiosk", EdgeKiosk);
            writer.WriteIntValue("edgeKioskIdleTimeoutMinutes", EdgeKioskIdleTimeoutMinutes);
            writer.WriteEnumValue<WindowsEdgeKioskType>("edgeKioskType", EdgeKioskType);
            writer.WriteBoolValue("edgeNoFirstRun", EdgeNoFirstRun);
        }
    }
}
