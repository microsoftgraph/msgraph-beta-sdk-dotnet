using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows management app health state entity.
    /// </summary>
    public class WindowsManagementAppHealthState : Entity, IParsable {
        /// <summary>Name of the device on which Windows management app is installed.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
        /// <summary>Windows 10 OS version of the device on which Windows management app is installed.</summary>
        public string DeviceOSVersion {
            get { return BackingStore?.Get<string>("deviceOSVersion"); }
            set { BackingStore?.Set("deviceOSVersion", value); }
        }
        /// <summary>Indicates health state of the Windows management app.</summary>
        public Microsoft.Graph.Beta.Models.HealthState? HealthState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.HealthState?>("healthState"); }
            set { BackingStore?.Set("healthState", value); }
        }
        /// <summary>Windows management app installed version.</summary>
        public string InstalledVersion {
            get { return BackingStore?.Get<string>("installedVersion"); }
            set { BackingStore?.Set("installedVersion", value); }
        }
        /// <summary>Windows management app last check-in time.</summary>
        public DateTimeOffset? LastCheckInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckInDateTime"); }
            set { BackingStore?.Set("lastCheckInDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsManagementAppHealthState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsManagementAppHealthState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceOSVersion", n => { DeviceOSVersion = n.GetStringValue(); } },
                {"healthState", n => { HealthState = n.GetEnumValue<HealthState>(); } },
                {"installedVersion", n => { InstalledVersion = n.GetStringValue(); } },
                {"lastCheckInDateTime", n => { LastCheckInDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
