using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents wipe requests issued by tenant admin for Bring-Your-Own-Device(BYOD) Windows devices.</summary>
    public class WindowsInformationProtectionWipeAction : Entity, IParsable {
        /// <summary>Last checkin time of the device that was targeted by this wipe action.</summary>
        public DateTimeOffset? LastCheckInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckInDateTime"); }
            set { BackingStore?.Set("lastCheckInDateTime", value); }
        }
        /// <summary>The status property</summary>
        public ActionState? Status {
            get { return BackingStore?.Get<ActionState?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Targeted device Mac address.</summary>
        public string TargetedDeviceMacAddress {
            get { return BackingStore?.Get<string>("targetedDeviceMacAddress"); }
            set { BackingStore?.Set("targetedDeviceMacAddress", value); }
        }
        /// <summary>Targeted device name.</summary>
        public string TargetedDeviceName {
            get { return BackingStore?.Get<string>("targetedDeviceName"); }
            set { BackingStore?.Set("targetedDeviceName", value); }
        }
        /// <summary>The DeviceRegistrationId being targeted by this wipe action.</summary>
        public string TargetedDeviceRegistrationId {
            get { return BackingStore?.Get<string>("targetedDeviceRegistrationId"); }
            set { BackingStore?.Set("targetedDeviceRegistrationId", value); }
        }
        /// <summary>The UserId being targeted by this wipe action.</summary>
        public string TargetedUserId {
            get { return BackingStore?.Get<string>("targetedUserId"); }
            set { BackingStore?.Set("targetedUserId", value); }
        }
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
