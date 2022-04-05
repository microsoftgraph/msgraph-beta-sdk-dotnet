using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsManagementAppHealthState : Entity, IParsable {
        /// <summary>Name of the device on which Windows management app is installed.</summary>
        public string DeviceName { get; set; }
        /// <summary>Windows 10 OS version of the device on which Windows management app is installed.</summary>
        public string DeviceOSVersion { get; set; }
        /// <summary>Windows management app health state. Possible values are: unknown, healthy, unhealthy.</summary>
        public Microsoft.Graph.Beta.Models.HealthState? HealthState { get; set; }
        /// <summary>Windows management app installed version.</summary>
        public string InstalledVersion { get; set; }
        /// <summary>Windows management app last check-in time.</summary>
        public DateTimeOffset? LastCheckInDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsManagementAppHealthState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsManagementAppHealthState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceName", (o,n) => { (o as WindowsManagementAppHealthState).DeviceName = n.GetStringValue(); } },
                {"deviceOSVersion", (o,n) => { (o as WindowsManagementAppHealthState).DeviceOSVersion = n.GetStringValue(); } },
                {"healthState", (o,n) => { (o as WindowsManagementAppHealthState).HealthState = n.GetEnumValue<HealthState>(); } },
                {"installedVersion", (o,n) => { (o as WindowsManagementAppHealthState).InstalledVersion = n.GetStringValue(); } },
                {"lastCheckInDateTime", (o,n) => { (o as WindowsManagementAppHealthState).LastCheckInDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceOSVersion", DeviceOSVersion);
            writer.WriteEnumValue<HealthState>("healthState", HealthState);
            writer.WriteStringValue("installedVersion", InstalledVersion);
            writer.WriteDateTimeOffsetValue("lastCheckInDateTime", LastCheckInDateTime);
        }
    }
}
