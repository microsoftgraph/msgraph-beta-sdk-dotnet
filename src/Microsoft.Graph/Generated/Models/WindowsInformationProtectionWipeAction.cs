using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsInformationProtectionWipeAction : Entity, IParsable {
        /// <summary>Last checkin time of the device that was targeted by this wipe action.</summary>
        public DateTimeOffset? LastCheckInDateTime { get; set; }
        /// <summary>Wipe action status. Possible values are: none, pending, canceled, active, done, failed, notSupported.</summary>
        public ActionState? Status { get; set; }
        /// <summary>Targeted device Mac address.</summary>
        public string TargetedDeviceMacAddress { get; set; }
        /// <summary>Targeted device name.</summary>
        public string TargetedDeviceName { get; set; }
        /// <summary>The DeviceRegistrationId being targeted by this wipe action.</summary>
        public string TargetedDeviceRegistrationId { get; set; }
        /// <summary>The UserId being targeted by this wipe action.</summary>
        public string TargetedUserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsInformationProtectionWipeAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionWipeAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastCheckInDateTime", n => { LastCheckInDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<ActionState>(); } },
                {"targetedDeviceMacAddress", n => { TargetedDeviceMacAddress = n.GetStringValue(); } },
                {"targetedDeviceName", n => { TargetedDeviceName = n.GetStringValue(); } },
                {"targetedDeviceRegistrationId", n => { TargetedDeviceRegistrationId = n.GetStringValue(); } },
                {"targetedUserId", n => { TargetedUserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastCheckInDateTime", LastCheckInDateTime);
            writer.WriteEnumValue<ActionState>("status", Status);
            writer.WriteStringValue("targetedDeviceMacAddress", TargetedDeviceMacAddress);
            writer.WriteStringValue("targetedDeviceName", TargetedDeviceName);
            writer.WriteStringValue("targetedDeviceRegistrationId", TargetedDeviceRegistrationId);
            writer.WriteStringValue("targetedUserId", TargetedUserId);
        }
    }
}
