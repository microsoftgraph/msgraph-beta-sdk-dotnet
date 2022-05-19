using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents device registration records for Bring-Your-Own-Device(BYOD) Windows devices.</summary>
    public class WindowsInformationProtectionDeviceRegistration : Entity, IParsable {
        /// <summary>Device Mac address.</summary>
        public string DeviceMacAddress {
            get { return BackingStore?.Get<string>(nameof(DeviceMacAddress)); }
            set { BackingStore?.Set(nameof(DeviceMacAddress), value); }
        }
        /// <summary>Device name.</summary>
        public string DeviceName {
            get { return BackingStore?.Get<string>(nameof(DeviceName)); }
            set { BackingStore?.Set(nameof(DeviceName), value); }
        }
        /// <summary>Device identifier for this device registration record.</summary>
        public string DeviceRegistrationId {
            get { return BackingStore?.Get<string>(nameof(DeviceRegistrationId)); }
            set { BackingStore?.Set(nameof(DeviceRegistrationId), value); }
        }
        /// <summary>Device type, for example, Windows laptop VS Windows phone.</summary>
        public string DeviceType {
            get { return BackingStore?.Get<string>(nameof(DeviceType)); }
            set { BackingStore?.Set(nameof(DeviceType), value); }
        }
        /// <summary>Last checkin time of the device.</summary>
        public DateTimeOffset? LastCheckInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastCheckInDateTime)); }
            set { BackingStore?.Set(nameof(LastCheckInDateTime), value); }
        }
        /// <summary>UserId associated with this device registration record.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsInformationProtectionDeviceRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionDeviceRegistration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceMacAddress", n => { DeviceMacAddress = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationId", n => { DeviceRegistrationId = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetStringValue(); } },
                {"lastCheckInDateTime", n => { LastCheckInDateTime = n.GetDateTimeOffsetValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceMacAddress", DeviceMacAddress);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceRegistrationId", DeviceRegistrationId);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteDateTimeOffsetValue("lastCheckInDateTime", LastCheckInDateTime);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
