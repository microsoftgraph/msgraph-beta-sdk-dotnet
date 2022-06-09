using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsHealthMonitoringConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Enables device health monitoring on the device. Possible values are: notConfigured, enabled, disabled.</summary>
        public Enablement? AllowDeviceHealthMonitoring {
            get { return BackingStore?.Get<Enablement?>(nameof(AllowDeviceHealthMonitoring)); }
            set { BackingStore?.Set(nameof(AllowDeviceHealthMonitoring), value); }
        }
        /// <summary>Specifies custom set of events collected from the device where health monitoring is enabled</summary>
        public string ConfigDeviceHealthMonitoringCustomScope {
            get { return BackingStore?.Get<string>(nameof(ConfigDeviceHealthMonitoringCustomScope)); }
            set { BackingStore?.Set(nameof(ConfigDeviceHealthMonitoringCustomScope), value); }
        }
        /// <summary>Specifies set of events collected from the device where health monitoring is enabled. Possible values are: undefined, healthMonitoring, bootPerformance, windowsUpdates.</summary>
        public WindowsHealthMonitoringScope? ConfigDeviceHealthMonitoringScope {
            get { return BackingStore?.Get<WindowsHealthMonitoringScope?>(nameof(ConfigDeviceHealthMonitoringScope)); }
            set { BackingStore?.Set(nameof(ConfigDeviceHealthMonitoringScope), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsHealthMonitoringConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsHealthMonitoringConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowDeviceHealthMonitoring", n => { AllowDeviceHealthMonitoring = n.GetEnumValue<Enablement>(); } },
                {"configDeviceHealthMonitoringCustomScope", n => { ConfigDeviceHealthMonitoringCustomScope = n.GetStringValue(); } },
                {"configDeviceHealthMonitoringScope", n => { ConfigDeviceHealthMonitoringScope = n.GetEnumValue<WindowsHealthMonitoringScope>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Enablement>("allowDeviceHealthMonitoring", AllowDeviceHealthMonitoring);
            writer.WriteStringValue("configDeviceHealthMonitoringCustomScope", ConfigDeviceHealthMonitoringCustomScope);
            writer.WriteEnumValue<WindowsHealthMonitoringScope>("configDeviceHealthMonitoringScope", ConfigDeviceHealthMonitoringScope);
        }
    }
}
